using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Client;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Castle.Core.Resource;
using System.IO;
using System.Reflection.Emit;

namespace CapaNegocio;

///<author> Miguel Ángel Moreno García</author>
public class Ventas : IDisposable
{
    private bool disposedValue;

    //************PRIMERA ENTREGA*******************//
    public static List<Order?> ListarPedidos()
    {
        return CapaDatos.OrderDAO.Listar().ToList();
    }

    /*Cargará todos los datos del pedido, incluyendo sus
    Order_items. Se deberá mostrar la información más relevante de los productos (su
    producto_name y model_year, no solo su ID.*/

    public static DataTable? DatosPedido(int Order_id)
    { 
        Order? order = (Order?) OrderDAO.Listar().Where(o => o.OrderId == Order_id).FirstOrDefault();
        List<OrderItem> orderItems;
        List<Product> products;

        //Crear el DataTable para guardar los datos
        DataTable? dataTable = new DataTable();
        //Datos extraidos tabla Orders
        dataTable.Columns.Add("Order ID");
        dataTable.Columns.Add("Customer ID");
        dataTable.Columns.Add("Order status");
        dataTable.Columns.Add("Order date");
        dataTable.Columns.Add("Required date");
        dataTable.Columns.Add("Shipped date");
        dataTable.Columns.Add("StoreID");
        dataTable.Columns.Add("StaffID");
        //Datos extraidos tabla OrderItems
        dataTable.Columns.Add("Item ID");
        dataTable.Columns.Add("Quantity");
        dataTable.Columns.Add("List price");
        dataTable.Columns.Add("Discount");
        //Datos extraidos tabla Products
        dataTable.Columns.Add("Product ID");
        dataTable.Columns.Add("Product name");
        dataTable.Columns.Add("Model year");

        if (order != null)
        {
            orderItems = OrderItemDAO.Listar().Where(oi => oi.OrderId == order.OrderId).ToList().ToList();

            foreach (OrderItem orderItem in orderItems)
            {
                products = ProductDAO.Listar().Where(p => p.ProductId == orderItem.ProductId).ToList();

                foreach (Product product in products)
                {
                    dataTable.Rows.Add(
                        order.OrderId,
                        order.CustomerId,
                        order.OrderStatus,
                        order.OrderDate,
                        order.RequiredDate,
                        order.ShippedDate,
                        order.StoreId,
                        order.StaffId,
                        orderItem.ItemId,
                        orderItem.Quantity,
                        orderItem.ListPrice,
                        orderItem.Discount,
                        product.ProductId,
                        product.ProductName,
                        product.ModelYear
                    );
                }      
            }
        }
        return dataTable;
    }
    //Cargará todos los pedidos realizados por un empleado. 
    public static List<Order?> ListarPedidosEmpleado(int EmployeeID)
    {
        return OrderDAO.Listar().Where(p => p.StaffId == EmployeeID).ToList();
    }

    //Obtendrá todos los pedidos de un cliente,llamando a la función DatosPedido, para obtener los detalles. 

    public static DataTable? ListarPedidosCliente(int CustomerID)
    {
        List<Order?> pedidosCliente = OrderDAO.Listar().Where(p => p.CustomerId == CustomerID).ToList();
        DataTable? tablasPedidos = new DataTable();

        //Datos extraidos tabla Orders
        tablasPedidos.Columns.Add("Order ID");
        tablasPedidos.Columns.Add("Customer ID");
        tablasPedidos.Columns.Add("Order status");
        tablasPedidos.Columns.Add("Order date");
        tablasPedidos.Columns.Add("Required date");
        tablasPedidos.Columns.Add("Shipped date");
        tablasPedidos.Columns.Add("StoreID");
        tablasPedidos.Columns.Add("StaffID");
        //Datos extraidos tabla OrderItems
        tablasPedidos.Columns.Add("Item ID");
        tablasPedidos.Columns.Add("Quantity");
        tablasPedidos.Columns.Add("List price");
        tablasPedidos.Columns.Add("Discount");
        //Datos extraidos tabla Products
        tablasPedidos.Columns.Add("Product ID");
        tablasPedidos.Columns.Add("Product name");
        tablasPedidos.Columns.Add("Model year");

        if (pedidosCliente.Count > 0)
        {
            foreach (Order o in pedidosCliente)
            {
                DataTable? datos = DatosPedido(o.OrderId);

                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    tablasPedidos.ImportRow(datos.Rows[i]);
                }
            }
        }
        return tablasPedidos;
    }

    //CRUD
    public static void InsertarOrder(Order order)
    {
        if (ListarPedidos().Exists(o => o.OrderId == order.OrderId)){
            throw new Exception("El id ya se encuentra en el registro");
        }
        else
        {
            OrderDAO.Insertar(order);
        }
    }
    public static void ActualizarOrder(Order order)
    {
        if(ListarPedidos().Exists(o => o.OrderId == order.OrderId))
        {
            OrderDAO.Actualizar(order);
        }
        else
        {
            throw new Exception("El id introducido no existe en la base de datos");
        }
        
    }
    public static void BorrarOrder(Order order)
    {
        if (ListarPedidos().Exists(o => o.OrderId == order.OrderId))
        {
            OrderDAO.Borrar(order);
        }
        else
        {
            throw new Exception("El id introducido no existe en la base de datos");
        }
    }
    //********************************************************************//

    //************SEGUNDA ENTREGA*******************//
    //Validación formulario LogIn

    public static Staff ObtenerEmpleadoRegistrado(string email, string pass)
    {
        using(StaffDAO staff = new StaffDAO())
        {
           return staff.ObtenerEmpleadoRegistrado(email, Validaciones.HashPassword(pass));
        }
    }
    public bool VerificarEmail(string email)
    {
        using (StaffDAO staff = new StaffDAO())
        {
            return staff.VerificarEmail(email);
        }
    }
    //********************************************************************//

    //************TERCERA ENTREGA*******************//
    public static List<Staff> ListarStaff()
    {
        return StaffDAO.Listar().ToList();
    }
    public static List<Store> ListarStores()
    {
        return StoreDAO.Listar().ToList();
    }
    public static void InsertarStaff(Staff staff)
    {
        StaffDAO.Insertar(staff);
    }
    public static void ActualizarStaff(Staff staff)
    {
        StaffDAO.Actualizar(staff);
    }
    public static DataTable? EmpleadosActivos()
    {
        List<Staff?> staffActivo = new List<Staff?>();
        using(var s = new StaffDAO())
        {
            staffActivo = s.ListarEmpleadoActivos().ToList();
        }
        DataTable? tablaStaff = new DataTable();

        //Datos extraidos tabla Staff
        tablaStaff.Columns.Add("ID");
        tablaStaff.Columns.Add("Nombre");
        tablaStaff.Columns.Add("Apellidos");
        tablaStaff.Columns.Add("Email");
        tablaStaff.Columns.Add("Teléfono");
        tablaStaff.Columns.Add("Nombre Tienda");
        tablaStaff.Columns.Add("Nombre Mánager");
        
        if(staffActivo != null)
        {
            foreach (Staff s in staffActivo)
            {
                string managerNombre = s.Manager != null ? s.Manager.FirstName : "";
                string telefono = s.Phone != null ? s.Phone : "";
                tablaStaff.Rows.Add(
                    s.StaffId,
                    s.FirstName,
                    s.LastName,
                    s.Email,
                    telefono,
                    s.Store.StoreName,
                    managerNombre
                    );
            }
        }
        else
        {
            tablaStaff.Rows.Add("Tabla vacía");
        }
        
        return tablaStaff;
    }
    public Staff ObtenerStaff(int id)
    {
        using(var s = new StaffDAO())
        {
            return s.ObtenerStaff(id);
        }
    }

    //********************************************************************//
    //***************CUARTA ENTREGA***************************************//
    const decimal IVA = 21;
    public Customer? ObtenerCliente(int id)
    {
        return CustomerDAO.Listar().Where(c => c.CustomerId == id).FirstOrDefault();
    }
    public static DataTable? ObtenerClientes()
    {
        List<Customer?> clientes = CustomerDAO.Listar().ToList();

        DataTable? tablaClientes = new DataTable();

        //Datos extraidos tabla Customer
        tablaClientes.Columns.Add("ID");
        tablaClientes.Columns.Add("Nombre");
        tablaClientes.Columns.Add("Apellidos");
        tablaClientes.Columns.Add("Email");
        tablaClientes.Columns.Add("Teléfono");
        tablaClientes.Columns.Add("Calle");
        tablaClientes.Columns.Add("Estado");
        tablaClientes.Columns.Add("Código Postal");
        tablaClientes.Columns.Add("Pedidos");


        if (clientes != null)
        {
            foreach (Customer c in clientes)
            {
                string telefono = c.Phone != null ? c.Phone : "";
                string calle = c.Street != null ? c.Street : "";
                string estado = c.State != null ? c.State : "";
                string codigoPostal = c.ZipCode != null ? c.ZipCode : "";

                tablaClientes.Rows.Add(
                    c.CustomerId,
                    c.FirstName,
                    c.LastName,
                    c.Email,
                    telefono,
                    calle,
                    estado,
                    codigoPostal,
                    c.Orders
                    );
            }
        }
        else
        {
            tablaClientes = null;
        }

        return tablaClientes;

    }
    public Product ObtenerProducto(int id)
    {
        return ProductDAO.Listar().Where(p => p.ProductId == id).FirstOrDefault();
    }
    public static DataTable? ObtenerProductos()
    {
        List<Product?> productos = ProductDAO.Listar().ToList();


        DataTable? tablaProductos = new DataTable();

        //Datos extraidos tabla Customer
        tablaProductos.Columns.Add("ID");
        tablaProductos.Columns.Add("Nombre");
        tablaProductos.Columns.Add("Marca");
        tablaProductos.Columns.Add("Categoria");
        tablaProductos.Columns.Add("Modelo");
        tablaProductos.Columns.Add("Precio");
        tablaProductos.Columns.Add("BrandId");
        tablaProductos.Columns.Add("CategoryId");


        if (productos != null)
        {
            foreach (Product producto in productos)
            {
                tablaProductos.Rows.Add(
                    producto.ProductId,
                    producto.ProductName,
                    producto.Brand.BrandName,
                    producto.Category.CategoryName,
                    producto.ModelYear,
                    producto.ListPrice,
                    producto.BrandId,
                    producto.CategoryId
                    );
            }
        }
        else
        {
            tablaProductos = null;
        }

        return tablaProductos;

    }
    public decimal CalcularPrecio(int cantidadProductos, decimal precio, bool impuestos, decimal descuento = 0)
    {
        decimal precioTotal = cantidadProductos * precio;

        if (impuestos)
        {
            precioTotal = precioTotal + (precioTotal * (IVA / 100));
        }

        return precioTotal - (precioTotal * (descuento / 100));
    }
    public void InsertarPedido(Order pedido)
    {
        OrderDAO.Insertar(pedido);
    }
    public Order RecuperarUltimoPedidoInsertado()
    {
        return OrderDAO.RecuperarUltimoPedido();
    }
    public void InsertarProductosPedido(OrderItem orderItem)
    {
        OrderItemDAO.Insertar(orderItem);
    }
    public int? ObtenerStock(int idStore, int idProduct)
    {
        using(var stock = new StockDAO())
        {
            return stock.ObtenerStock(idStore, idProduct);
        }
    }
    public void ActualizarStock(Stock stockActualizar)
    {
        using(var stock = new StockDAO())
        {
            stock.Actualizar(stockActualizar);
        }
    }

    //********************************************************************//
    public static DataTable? ListarPedidosPersonalizado()
    {
        return OrderDAO.ListarPedidos();
    }
    public static DataTable? ListarProductosPedido(int idPedido)
    {
        return OrderItemDAO.ListarProductosPedido(idPedido);
    }
    //********************************************************************//
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: eliminar el estado administrado (objetos administrados)
            }

            // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
            // TODO: establecer los campos grandes como NULL
            disposedValue = true;
        }
    }
    public void Dispose()
    {
        // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

