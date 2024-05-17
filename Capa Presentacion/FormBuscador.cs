using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///<author> Miguel Ángel Moreno García</author>

namespace Capa_Presentacion
{
    public partial class FormBuscador : Form
    {
        private DataTable? dataTable;
        private FormAltaPedido? formAltaPedido;
        private string tipo;
        public Action productoAnyadido;
        public Action clienteAnyadido;
        public Customer? clientePulsado;
        public FormBuscador(string tipo, FormAltaPedido formAltaPedido = null)
        {
            InitializeComponent();
            this.formAltaPedido = formAltaPedido;
            this.tipo = tipo;

            if (tipo == "cliente")
            {
                //Cargamos los datos de los clientes en el dataGrid al crearse el formularioe
                dataTable = Ventas.ObtenerClientes();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["ID"].Visible = false; //Oculto la columna de ID al usuario
                dataGridView1.Columns["Pedidos"].Visible = false;
            }
            else if(tipo == "producto")
            {
                //Cargamos los datos de los productos en el dataGrid al crearse el formulario
                dataTable = Ventas.ObtenerProductos();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["ID"].Visible = false; //Oculto la columna de ID al usuario
                dataGridView1.Columns["BrandId"].Visible = false;
                dataGridView1.Columns["CategoryId"].Visible = false;
            }
            else if(tipo == "factura")
            {
                //Cargamos los datos de los pedidos en el dataGrid
                dataTable = Ventas.ListarPedidosPersonalizado();
                dataGridView1.DataSource = dataTable;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView filtrado = new DataView(dataTable);
            string busqueda = textBox1.Text;

            if(tipo == "cliente")
            {
                filtrado.RowFilter = $"Nombre LIKE '%{busqueda}%' OR Apellidos LIKE '%{busqueda}%' OR Email LIKE '%{busqueda}%' OR Teléfono LIKE '%{busqueda}%'";
            }
            else if(tipo == "producto")
            {
                filtrado.RowFilter = $"Nombre LIKE '%{busqueda}%' OR Marca LIKE '%{busqueda}%' OR Categoria LIKE '%{busqueda}%'";
            }
            else if(tipo == "factura")
            {
                filtrado.RowFilter = $"NºPedido LIKE '%{busqueda}%' OR [Nombre cliente] LIKE '%{busqueda}%' OR [Nombre tienda] LIKE '%{busqueda}%'";
            }
            
            dataGridView1.DataSource = filtrado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtengo los valores de la fila seleccionada
            if(e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                if (tipo == "cliente")
                {
                    using (var ventas = new Ventas())
                    {
                        clientePulsado = ventas.ObtenerCliente(Convert.ToInt32(fila.Cells[0].Value));
                        clienteAnyadido.Invoke();
                    }
                    //Escribo el valor de las celas correspondientes en el formulario AltaProducto
                    formAltaPedido.tbNombre.Text = fila.Cells[1].Value.ToString();
                    formAltaPedido.tbApellidos.Text = fila.Cells[2].Value.ToString();
                    formAltaPedido.tbEmail.Text = fila.Cells[3].Value.ToString();
                    formAltaPedido.tbTelefono.Text = fila.Cells[4].Value.ToString();
                }
                else if (tipo == "factura")
                {
                    FormInforme formInforme = new FormInforme(fila);
                    formInforme.Show();
                    formInforme.MdiParent = this.MdiParent;
                    this.Close();
                }
                else
                {
                    if (formAltaPedido != null)
                    {
                        //Creo el objeto producto utilizando los valores de la fila seleccionada por el usuario
                        Product nuevoProducto;
                        using (var ventas = new Ventas())
                        {
                            nuevoProducto = ventas.ObtenerProducto(Convert.ToInt32(fila.Cells["ID"].Value));
                        }


                        Store tienda = (Store)formAltaPedido.cbTienda.SelectedItem;

                        using (var ventas = new Ventas())
                        {
                            int? stock = ventas.ObtenerStock(tienda.StoreId, nuevoProducto.ProductId);

                            if (stock == null || stock == 0)
                            {
                                MessageBox.Show("Ese producto no tiene stock en la tienda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (formAltaPedido.preciosProductos.ContainsKey(nuevoProducto.ProductId) && !formAltaPedido.ComprobarStock(nuevoProducto.ProductId, tienda.StoreId))
                                {
                                    MessageBox.Show("No se pueden añadir más productos. No hay más stock en esta tienda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    formAltaPedido.ListaProductos.Add(nuevoProducto);
                                }

                            }
                        }
                        //Invoco el evento de producto añadido para que se actualice el datagrid con los productos
                        productoAnyadido.Invoke();
                    }

                }

            }
        }
            
    }
}
