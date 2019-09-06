using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar=1;

            
        private Dolar()
        {
            this.cantidad = 0;            
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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



        
         public static explicit operator Euro(Dolar d)
         {
            Euro retorno = new Euro(1);

            //d.GetCantidad()*Dolar.GetCotizacion();


            return retorno;

         }

        /*


         public static explicit operator Peso(Dolar d)
         {


         }



         public static implicit operator Dolar(double d)
         {

         }

         */



        /*
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad()==e.GetCantidad();

        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return(!d==e);
        }


        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad()==p.GetCantidad());
        }


        public static bool operator !=(Dolar d, Peso p)
        {
            return (!d==p);
        }



        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return(d1.GetCantidad()==d2.GetCantidad());
        
        }


        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return(!d1==d2);
        
        }



        */


    }
}
