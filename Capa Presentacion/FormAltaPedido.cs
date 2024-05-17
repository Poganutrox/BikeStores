using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Castle.Core.Resource;
using Castle.Core.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<author>Miguel Ángel Moreno García</author>
namespace Capa_Presentacion
{
    public partial class FormAltaPedido : Form
    {
        public List<Product> ListaProductos { get; set; } = new List<Product>(); //Lista que se usa para mostrar los productos en tablaProductos
        public Dictionary<int, decimal[]> preciosProductos = new Dictionary<int, decimal[]>();//Guarda el id del producto y su precio [0], cantidad [1] y descuento [2]
        private Staff empleado;
        private Customer? cliente = null;
        private Store tienda = null;
        private List<Store> tiendas;
        public decimal precioConIVA = 0, precioSinIVA = 0;

        //Alertas de validación
        private ToolTip TTIP = new ToolTip();
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormAltaPedido(Staff staffRegistrado)
        {
            InitializeComponent();
            empleado = staffRegistrado;
            tbEmpleado.Text = staffRegistrado.FirstName;
            dataGridProductos.Columns["Nombre"].ReadOnly = true;

            //Introducimos los objectos Store dentro del ComboBox y mostramos el nombre de las tiendas
            tiendas = Ventas.ListarStores();
            cbTienda.DataSource = tiendas;
            cbTienda.ValueMember = "StoreId";
            cbTienda.DisplayMember = "StoreName";
            cbTienda.SelectedIndex = 0;
            cbTienda.SelectedItem.ToString();

            //Fecha en la que se crea el pedido (valor por defecto Hoy)
            dtCreacionPedido.Value = DateTime.Today;


            //Introducimos los 3 valores del ComboBox del Estado
            Dictionary<byte, string> estado = new Dictionary<byte, string>()
            {
                { 1,"Creado" },
                { 2,"Preparado" },
                { 3,"Enviado" }
            };
            cbEstado.DataSource = new BindingSource(estado, null);
            cbEstado.ValueMember = "Key";
            cbEstado.DisplayMember = "Value";

            //Atribuimos las variables de precio a sus textbox correspondientes
            tbPrecioSinIVA.Text = precioSinIVA.ToString();
            tbPrecioTotal.Text = precioConIVA.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBuscador formBuscarCliente = new FormBuscador("cliente", this);
            formBuscarCliente.clienteAnyadido += () =>
            {
                cliente = formBuscarCliente.clientePulsado;
            };
            formBuscarCliente.ShowDialog();

        }
        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            FormBuscador formBuscarProductos = new FormBuscador("producto", this);
            Ventas ventas = new Ventas();

            int cantidad;

            //Acción que se ejecuta en el momento en el que se pulsa uno de los productos de la tabla de buscar productos
            formBuscarProductos.productoAnyadido += () =>
            {
                //Desactivo el ComboBox de elegir tienda para que no haya problemas con el StoreId a la hora de insertar el pedido
                cbTienda.Enabled = false;

                // Limpiar el DataGridView
                dataGridProductos.Rows.Clear();

                var agrupacionProductos = ListaProductos.GroupBy(p => p.ProductId).ToList(); //Agrupo los productos por id

                foreach (var grupo in agrupacionProductos)
                {
                    cantidad = grupo.Count(); //Cantidad de veces que ha sido añadido el mismo producto a la lista
                    Product producto = grupo.First(); //Obtengo el producto 

                    //Añado el producto a la tablaProductos
                    dataGridProductos.Rows.Add(
                        producto.ProductId,
                        cantidad,
                        producto.ProductName,
                        producto.ListPrice,
                        ""
                        );

                    if (preciosProductos.ContainsKey(producto.ProductId))
                    {
                        preciosProductos[producto.ProductId] = new decimal[] { ventas.CalcularPrecio(cantidad, producto.ListPrice, false), cantidad, 0 };
                    }
                    else
                    {
                        preciosProductos.Add(producto.ProductId, new decimal[] { ventas.CalcularPrecio(cantidad, producto.ListPrice, false), cantidad, 0 });
                    }
                }
                ActualizarPrecio();
            };

            formBuscarProductos.ShowDialog();
        }
        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridProductos.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                int id = Convert.ToInt32(dataGridProductos.Rows[e.RowIndex].Cells["ID"].Value);

                // Encuentra el producto en la lista
                Product productoAEliminar = ListaProductos.Find(p => p.ProductId == id);

                // Elimina el producto de la lista
                if (productoAEliminar != null)
                {
                    ListaProductos.RemoveAll(p => p.ProductId == productoAEliminar.ProductId);//Elimino todos los productos iguales
                }

                dataGridProductos.Rows.RemoveAt(e.RowIndex); //Elimino la fila
                preciosProductos.Remove(id); //Elimino el producto del diccionario de cantidades, descuentos y precios
                if (ListaProductos.Count == 0) { cbTienda.Enabled = true; } //Si la lista de productos se vacia por completo,
                                                                            //se vuelve a habilitar la posibilidad de elegir tienda
                ActualizarPrecio();
            }
        }

        int valorAnteriorCantidad;
        private void dataGridProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridProductos.Columns["Cantidad"].Index)
            {
                var valorCelda = dataGridProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                valorAnteriorCantidad = valorCelda == null || valorCelda.ToString() == "" ? 0 : Convert.ToInt32(valorCelda);
            }
        }
        private void dataGridProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad;
            decimal descuento;
            decimal precio;
            var filaCambiada = dataGridProductos.Rows[e.RowIndex];
            int id = Convert.ToInt32(filaCambiada.Cells["ID"].Value);

            precio = Convert.ToDecimal(filaCambiada.Cells["Precio"].Value);
            descuento = filaCambiada.Cells["Descuento"].Value.ToString() == "" ? 0 : Convert.ToDecimal(filaCambiada.Cells["Descuento"].Value);
            cantidad = filaCambiada.Cells["Cantidad"].Value.ToString() == "" ? 1 : Convert.ToInt32(filaCambiada.Cells["Cantidad"].Value);


            using (var ventas = new Ventas())
            {
                preciosProductos[id] = new decimal[] { ventas.CalcularPrecio(cantidad, precio, false, descuento), cantidad, descuento };

                if (!ComprobarStock(id, tienda.StoreId))
                {
                    dataGridProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = valorAnteriorCantidad;
                    preciosProductos[id] = new decimal[] { ventas.CalcularPrecio(cantidad, precio, false, descuento), valorAnteriorCantidad, descuento };
                    MessageBox.Show("No hay stock suficiente en la tienda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    ActualizarPrecio();
                }
            }
        }
        private void ActualizarPrecio()
        {
            precioSinIVA = 0;
            precioConIVA = 0;

            foreach (int id in preciosProductos.Keys)
            {
                precioSinIVA += preciosProductos[id][0];
            }
            tbPrecioSinIVA.Text = precioSinIVA.ToString("#.##");

            using (var ventas = new Ventas())
            {
                tbPrecioTotal.Text = ventas.CalcularPrecio(1, precioSinIVA, true).ToString("#.##");
            }
        }
        private bool ValidarPedido()
        {
            string cadenaErrores = "";
            bool valCliente = false;
            bool valProductos = false;

            if (cliente == null)
            {
                cadenaErrores = "El pedido debe tener un cliente asociado";
                valCliente = false;
                MostrarError(btnBuscarCliente, cadenaErrores);
            }
            else
            {
                LimpiarError(btnBuscarCliente);
                valCliente = true;
            }

            if (ListaProductos.Count == 0)
            {
                cadenaErrores = "No se puede crear un pedido sin productos";
                MostrarError(btnBuscarProductos, cadenaErrores);
                valProductos = false;
            }
            else
            {
                LimpiarError(btnBuscarProductos);
                valProductos = true;
            }

            if (valCliente && valProductos) { return true; }
            return false;
        }
        private void MostrarError(Control control, string mensaje)
        {
            control.BackColor = Color.LightCoral;
            TTIP.SetToolTip(control, mensaje);
            errorProvider.SetError(control, mensaje);
        }
        private void LimpiarError(Control control)
        {
            control.BackColor = Color.GreenYellow;
            TTIP.SetToolTip(control, "");
            errorProvider.SetError(control, "");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            tienda = (Store)cbTienda.SelectedItem;
            int? customerId;
            int storeId, staffId;
            byte orderStatus;
            DateTime requiredDate, orderDate;
            DateTime? shippedDate;

            customerId = cliente?.CustomerId;
            storeId = tienda.StoreId;
            staffId = empleado.StaffId;
            requiredDate = dtPreparacionPedido.Value;
            orderDate = dtCreacionPedido.Value;
            shippedDate = dtEnvioPedido.Enabled ? dtEnvioPedido.Value : (DateTime?)null;
            orderStatus = (byte)cbEstado.SelectedValue;

            if (ValidarPedido())
            {
                Ventas ventas = new Ventas();
                //Creamos el pedido con sus datos y lo insertamos en la base de datos
                Order nuevoPedido = new Order(customerId, orderStatus, orderDate, requiredDate, shippedDate, storeId, staffId);
                ventas.InsertarPedido(nuevoPedido);
                //Recuperamos el pedido recien insertado para obtener el id creado por la base de datos
                Order pedidoInsertado = ventas.RecuperarUltimoPedidoInsertado();

                var agrupacionProductos = ListaProductos.GroupBy(p => p.ProductId).ToList(); //Agrupo los productos por id
                for (int i = 0; i < agrupacionProductos.Count; i++)
                {
                    Product producto = agrupacionProductos[i].First();
                    int cantidad = Convert.ToInt32(preciosProductos[producto.ProductId][1]);
                    decimal descuento = preciosProductos[producto.ProductId][2];

                    //Añadiendo los productos en la tabla OrderItems
                    OrderItem productosPedido = new OrderItem(pedidoInsertado.OrderId, i + 1, producto.ProductId, cantidad, producto.ListPrice, descuento);
                    ventas.InsertarProductosPedido(productosPedido);

                    //Actualizamos el stock de cada producto
                    int? stock = ventas.ObtenerStock(storeId, producto.ProductId);
                    Stock nuevoStock = new Stock(tienda.StoreId, producto.ProductId, stock - cantidad);
                    ventas.ActualizarStock(nuevoStock);
                }

                MessageBox.Show("¡Pedido creado con éxito!");
            }
        }
        public bool ComprobarStock(int idProduct, int idStore)
        {
            int? stock;
            using (var ventas = new Ventas())
            {
                stock = ventas.ObtenerStock(idStore, idProduct);
                if (preciosProductos[idProduct][1] >= stock) { return false; }
                return true;
            }

        }
        private void cbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            tienda = (Store)cbTienda.SelectedItem;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dtEnvioPedido.Enabled = false;
            }
            else
            {
                dtEnvioPedido.Enabled = true;
            }
        }
    }
}
