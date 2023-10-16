using CapaEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{

    ///<author> Miguel Ángel Moreno García</author>
    public class OrderDAO : IDisposable
    {
        private bool disposedValue;

        //CRUD
        public static IList<Order> Listar()
        {
            using (var context = new BikeStoresContext())
            {
                return context.Orders.ToList();
            }
        }
        public static void Insertar(Order dato)
        {
            using (var context = new BikeStoresContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public static void Actualizar(Order modificado)
        {
            using (var context = new BikeStoresContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void Borrar(Order dato)
        {
            using (var context = new BikeStoresContext())
            {
                context.Entry(dato).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //Obtención información
        /*Métodos alternativos no utilizados en la versión final de ejercicio
         * 
        public static List<Object?> DatosPedido(int orderId)
        {
            using(var context = new BikeStoresContext())
            {
                var query = from or in context.Orders
                            join orIt in context.OrderItems
                            on or.OrderId equals orIt.OrderId
                            join pro in context.Products
                            on orIt.ProductId equals pro.ProductId
                            where or.OrderId == orderId
                            select new { or.OrderId, or.CustomerId,or.OrderStatus,
                                or.OrderDate, or.RequiredDate, or.ShippedDate, or.StoreId,or.StaffId,
                                orIt.ProductId, orIt.Quantity,orIt.ListPrice,orIt.Discount,
                                pro.ProductName, pro.ModelYear };

                List<Object?> resultado = new List<Object?>(query);
                return resultado;
            }
        }

        public static List<Order?> ListarPedidosEmpleado(int EmployeeID)
        {
            using(var context = new BikeStoresContext())
            {
                var query = from or in context.Orders
                            where or.StaffId == EmployeeID
                            select or;

                return query.ToList();
            }
        }

        public static List<Order?> ListarPedidosCliente(int CustomerID)
        {
            using (var context = new BikeStoresContext())
            {
                var query = from or in context.Orders
                            where or.CustomerId == CustomerID
                            select or;

                return query.ToList();
            }
        }
        */

        //Dispose
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
