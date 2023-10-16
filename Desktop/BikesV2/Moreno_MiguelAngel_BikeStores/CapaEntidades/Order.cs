using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Numerics;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace CapaEntidades;

///<author> Miguel Ángel Moreno García</author>
[Table("orders", Schema = "sales")]
public partial class Order : IDisposable
{
    private bool disposedValue;

    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [Column("order_status")]
    public byte OrderStatus { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime OrderDate { get; set; }

    [Column("required_date", TypeName = "date")]
    public DateTime RequiredDate { get; set; }

    [Column("shipped_date", TypeName = "date")]
    public DateTime? ShippedDate { get; set; }

    [Column("store_id")]
    public int StoreId { get; set; }

    [Column("staff_id")]
    public int StaffId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [ForeignKey("StaffId")]
    [InverseProperty("Orders")]
    public virtual Staff Staff { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("Orders")]
    public virtual Store Store { get; set; } = null!;

    public Order() { }

    //Constructor con todos los parámetros
    public Order(int orderId, int? customerId, byte orderStatus, DateTime orderDate, DateTime requiredDate, 
        DateTime? shippedDate, int storeId, int staffId, Customer? customer, ICollection<OrderItem> orderItems,
        Staff staff, Store store)
    {
        OrderId = orderId;
        CustomerId = customerId;
        OrderStatus = orderStatus;
        OrderDate = orderDate;
        RequiredDate = requiredDate;
        ShippedDate = shippedDate;
        StoreId = storeId;
        StaffId = staffId;
        Customer = customer;
        OrderItems = orderItems;
        Staff = staff;
        Store = store;
    }

    //Constructor con los parámetros obligatorios
    public Order(byte orderStatus, DateTime orderDate, DateTime requiredDate, int storeId, 
        int staffId)
    {
        OrderStatus = orderStatus;
        OrderDate = orderDate;
        RequiredDate = requiredDate;
        StoreId = storeId;
        StaffId = staffId;
    }

    // Constructor copia
    public Order(Order other)
    {
        OrderId = other.OrderId;
        CustomerId = other.CustomerId;
        OrderStatus = other.OrderStatus;
        OrderDate = other.OrderDate;
        RequiredDate = other.RequiredDate;
        ShippedDate = other.ShippedDate;
        StoreId = other.StoreId;
        StaffId = other.StaffId;
        Customer = other.Customer;
        OrderItems = other.OrderItems;
        Staff = other.Staff;
        Store = other.Store;
    }

    //ToString()
    public override string ToString()
    {
        return $"{OrderId}#{CustomerId}#{OrderStatus}#{OrderDate}#{RequiredDate}#{ShippedDate}#{StoreId}#{StaffId}#{Customer}" +
            $"#{OrderItems.Count}#{Staff}#{Store}";
    }

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

    // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
    // ~Order()
    // {
    //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
