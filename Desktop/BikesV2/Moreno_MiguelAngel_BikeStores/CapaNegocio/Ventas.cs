using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio;

///<author> Miguel Ángel Moreno García</author>
public class Ventas
{
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
}
