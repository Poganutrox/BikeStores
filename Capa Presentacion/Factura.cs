using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * <summary>
 * Clase que representa la generación de una factura utilizando un informe local (RDLC).
 * </summary>
 * <author>Miguel Ángel Moreno García</author>
 */

namespace Capa_Presentacion
{
    public class Factura
    {
        /*
         * <summary>
         * Carga los datos necesarios y genera una factura utilizando un informe local (RDLC).
         * </summary>
         * <param name="report">Informe local donde se generará la factura.</param>
         * <param name="orderSeleccionado">Fila de datos del pedido seleccionado en un DataGridView.</param>
         */
        public static void Load(LocalReport report, DataGridViewRow orderSeleccionado)
        {
            // Obtener datos de la fila del pedido seleccionado por el usuario
            string NumPedido, PreparacionPedido, CreacionPedido, NombreTienda, NombreCliente, ApellidosCliente, EmailCliente, TelefonoCliente, Nombre;
            string? EnvioPedido;
            decimal Precio, Descuento;

            NumPedido = orderSeleccionado.Cells["NºPedido"].Value.ToString();
            NombreCliente = orderSeleccionado.Cells["Nombre cliente"].Value.ToString();
            ApellidosCliente = orderSeleccionado.Cells["Apellido cliente"].Value.ToString();
            EmailCliente = orderSeleccionado.Cells["Email cliente"].Value.ToString();
            TelefonoCliente = orderSeleccionado.Cells["Telefono cliente"].Value.ToString();
            NombreTienda = orderSeleccionado.Cells["Nombre tienda"].Value.ToString();
            Nombre = orderSeleccionado.Cells["Nombre empleado"].Value.ToString();
            CreacionPedido = Convert.ToDateTime(orderSeleccionado.Cells["Fecha creación"].Value).ToString("dd/MM/yyyy");
            PreparacionPedido = Convert.ToDateTime(orderSeleccionado.Cells["Fecha preparación"].Value).ToString("dd/MM/yyyy");
            EnvioPedido = Convert.ToDateTime(orderSeleccionado.Cells["Fecha envio"].Value).ToString("dd/MM/yyyy");

            // Obtener todos los productos del pedido
            int idPedido = Convert.ToInt32(NumPedido);
            const decimal IVA = 21;
            decimal baseimponible = 0, totalIVA = 0, totalFactura = 0;
            DataTable? listaProductos = Ventas.ListarProductosPedido(idPedido);
            List<ElementosFactura> productos = new List<ElementosFactura>();

            // Iterar sobre los productos en la listaProductos
            foreach (DataRow row in listaProductos.Rows)
            {
                // Obtener los valores de cada columna en el DataRow
                int cantidadProducto = Convert.ToInt32(row["Cantidad"]);
                string nombreProducto = row["Producto"].ToString();
                decimal descuentoProducto = Convert.ToDecimal(row["Descuento"]);
                decimal precioProducto = Convert.ToDecimal(row["Precio"]);

                // Agregar el producto a la lista
                ElementosFactura producto = new ElementosFactura
                {
                    Cantidad = cantidadProducto,
                    Nombre = nombreProducto,
                    Descuento = (int)(descuentoProducto * 100),
                    Precio = precioProducto * cantidadProducto - descuentoProducto * precioProducto
                };
                productos.Add(producto);

                // Calcular el coste total del pedido
                baseimponible += producto.Precio;
            }

            // Calcular el coste del IVA y el coste de la factura con el IVA incluido
            totalIVA = baseimponible * (IVA / 100);
            totalFactura = baseimponible + totalIVA;

            // Parámetros para el informe
            var parameters = new[]
            {
                new ReportParameter("Nombre", "Miguel Ángel Moreno García"),
                new ReportParameter("DNI", "48762188A"),
                new ReportParameter("NombreCliente", NombreCliente),
                new ReportParameter("ApellidosCliente", ApellidosCliente),
                new ReportParameter("EmailCliente", EmailCliente),
                new ReportParameter("TelefonoCliente", TelefonoCliente),
                new ReportParameter("NumPedido", NumPedido),
                new ReportParameter("FechaCreacion", CreacionPedido),
                new ReportParameter("FechaPreparacion", PreparacionPedido),
                new ReportParameter("FechaEnvio", EnvioPedido),
                new ReportParameter("NombreTienda", NombreTienda),
                new ReportParameter("BaseImponible", baseimponible.ToString("#.##")),
                new ReportParameter("IVA", IVA.ToString()),
                new ReportParameter("TotalIVA", totalIVA.ToString("#.##")),
                new ReportParameter("TotalFactura", totalFactura.ToString("#.##"))
            };

            // Cargar el informe local desde un archivo "factura.rdlc"
            using var fs = new FileStream("factura.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);

            // Agregar la fuente de datos y establecer los parámetros
            report.DataSources.Add(new ReportDataSource("DatosProductos", productos));
            report.SetParameters(parameters);

            // Renderizar el informe como PDF
            byte[] pdf = report.Render("PDF");
        }
    }
}
