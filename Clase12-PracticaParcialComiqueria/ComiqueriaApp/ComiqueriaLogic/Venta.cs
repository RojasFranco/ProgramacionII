using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        #region Propiedades

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        #endregion


        #region Metodos

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);  //FALTABA ESTO
        }


        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }


        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double retorno;
            //retorno = (precioUnidad * cantidad) + ((precioUnidad * cantidad) * porcentajeIva / 100);
            retorno = (precioUnidad * cantidad) * (100+porcentajeIva) / 100;
            return retorno;
        }

        public string ObtenerDescripcionBreve()
        {
            string retorno = string.Empty;
            retorno = string.Format("\nfecha {0} – descripción {1} –precioFinal {2: 0.00}", this.fecha, producto.Descripcion, this.precioFinal);
            return retorno;
        }
        #endregion
    }
}
