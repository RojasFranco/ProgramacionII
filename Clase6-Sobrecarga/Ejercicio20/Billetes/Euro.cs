using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1.16;



        private Euro()
        {
            this.cantidad = 0;

        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;

        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }


        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }


        /*
        public static explicit operator Dolar(Euro e)
        {
            Dolar retorno = new Dolar();


            return retorno;
        }
        */

    }
}
