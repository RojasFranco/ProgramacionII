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
        private static double cotizRespectoDolar;


        #region Constructores

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }


        #endregion


        #region Metodos

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        
        #endregion


        public static void SetCotizacion(double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
        }


        #region Sobrecargas explicitas/implicitas

        public static explicit operator Euro(Dolar d)
        {

            double cantidadDolares = d.GetCantidad();
            double cantidadEuros = cantidadDolares / Euro.GetCotizacion(); // Convierto la cant dolares a euros

            Euro retorno = new Euro(cantidadEuros);
            return retorno;

            //return retorno;

        }




        public static explicit operator Peso(Dolar d)
        {
            double cantidadDolares = d.GetCantidad();
            double cantidadPesos = cantidadDolares / Peso.GetCotizacion();
            Peso retorno = new Peso(cantidadPesos);
            return retorno;
        }



        public static implicit operator Dolar(double d)
        {
            Dolar retorno = new Dolar(d);
            return retorno;
        }


        #endregion


        #region Sobrecargas

        public static bool operator ==(Dolar d, Euro e)
        {
            //return d == e;
            return d.GetCantidad() == e.GetCantidad();

        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }


        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad() == p.GetCantidad());
        }


        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }



        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() == d2.GetCantidad());

        }


        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);

        }

        #endregion


        #region Sobrecargas operaciones

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar auxDolar = (Dolar)euro;
            double cantidadAuxiliar = dolar.GetCantidad() - auxDolar.GetCantidad();

            Dolar retorno = new Dolar(cantidadAuxiliar);
            return retorno;
        }
    
        public static Dolar operator +(Dolar dolar, Euro euro)
        {

            Dolar auxDolar =(Dolar) euro;
            double cantidadAuxiliar = auxDolar.GetCantidad();

            Dolar retorno = new Dolar(cantidadAuxiliar);
            return retorno;
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            Dolar auxDolar = (Dolar) peso;
            double cantidadAuxiliar = auxDolar.GetCantidad() + dolar.GetCantidad();

            Dolar retorno = new Dolar(cantidadAuxiliar);
            return retorno;
        }
        
        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            Dolar auxDolar = (Dolar)peso;
            double cantidadAuxiliar = auxDolar.GetCantidad() - dolar.GetCantidad();

            Dolar retorno = new Dolar(cantidadAuxiliar);
            return retorno;
        }

        #endregion
              
        
    }
}
