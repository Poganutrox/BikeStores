using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * <summary>
 * Clase que representa los elementos individuales de una factura, como productos y sus detalles.
 * </summary>
 * <author>Miguel Ángel Moreno García</author>
 */

namespace Capa_Presentacion
{
    public class ElementosFactura
    {
        /*
         * <summary>
         * Obtiene o establece la cantidad de unidades del producto.
         * </summary>
         */
        public int Cantidad { get; set; }

        /*
         * <summary>
         * Obtiene o establece el nombre del producto.
         * </summary>
         */
        public string Nombre { get; set; }

        /*
         * <summary>
         * Obtiene o establece el porcentaje de descuento aplicado al producto.
         * </summary>
         */
        public int Descuento { get; set; }

        /*
         * <summary>
         * Obtiene o establece el precio del producto, redondeado a dos decimales.
         * </summary>
         */
        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = Math.Round(value, 2); }
        }
    }
}
