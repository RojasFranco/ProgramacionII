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
        private static double cotizRespectoDolar;


        #region Constructores

        private Euro()
        {
            cotizRespectoDolar = 1/1.16;

        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;

        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
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


        #region Sobrecargas explicitas/implicitas

        public static explicit operator Dolar(Euro e)
        {
            double cantidadEuros = e.GetCantidad();
            double cantidadDolares = cantidadEuros * Euro.GetCotizacion();

            Dolar retorno = new Dolar(cantidadDolares);
            return retorno;
        }

        public static explicit operator Peso(Euro e)
        {
            double cantidadEuros = e.GetCantidad();
            double cantidadDolares = cantidadEuros * Euro.GetCotizacion();
            double cantidadPesos = cantidadDolares / Peso.GetCotizacion();

            Peso retorno = new Peso(cantidadPesos);
            return retorno;
            //podia hacer Peso retorno = (Peso)Dolar(cantidadDolares);?
        }

        public static implicit operator Euro(double d)
        {
            Euro retorno = new Euro(d);
            return retorno;
        }

        #endregion


        #region Sobrecargas

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == p.GetCantidad();

        }

        public static bool operator!=(Euro e, Peso p)
        {

            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        #endregion


        #region Sobrecargas operaciones

        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro retorno = new Euro(euro.GetCantidad() + ((Euro)dolar).GetCantidad());
            return retorno;
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro retorno = new Euro(euro.GetCantidad() - ((Euro)dolar).GetCantidad());
            return retorno;
        }

        public static Euro operator +(Euro euro, Peso peso)
        {
            Euro retorno = new Euro(euro.GetCantidad() + ((Euro)peso).GetCantidad());
            return retorno;
        }

        public static Euro operator -(Euro euro, Peso peso)
        {
            Euro retorno = new Euro(euro.GetCantidad() - ((Euro)peso).GetCantidad());
            return retorno;
        }

        #endregion

    }
}
