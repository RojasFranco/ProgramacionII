using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;   //Dolares por peso

        #region Constructores

        private Peso()
        {
            cotizRespectoDolar = 1/38.33;
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;

        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Peso p)
        {
            double cantidadPesos = p.GetCantidad();
            double cantidadDolares = cantidadPesos * Peso.GetCotizacion();

            Dolar retorno = new Dolar(cantidadDolares);
            return retorno;
        }

        public static explicit operator Euro(Peso p)
        {
            double cantidadPesos = p.GetCantidad();
            double cantidadDolares = cantidadPesos * Peso.GetCotizacion();
            double cantidadEuros = cantidadDolares / Euro.GetCotizacion();

            Euro retorno = new Euro(cantidadEuros);
            return retorno;
        }

        public static implicit operator Peso(double d)
        {
            Peso retorno = new Peso(d);
            return retorno;
        }

        #endregion


        #region Sobrecargas

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);

        }


        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad();

        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }


        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();

        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        #endregion


        #region Sobrecargas operaciones
        
        public static Peso operator +(Peso peso, Dolar dolar)
        {
            Peso retorno = new Peso(peso.GetCantidad() + ((Peso)dolar).GetCantidad() );
            return retorno;
        }

        public static Peso operator -(Peso peso, Dolar dolar)
        {
            Peso retorno = new Peso(peso.GetCantidad() - ((Peso)dolar).GetCantidad() );
            return retorno;

        }

        public static Peso operator +(Peso peso, Euro euro)
        {
            Peso retorno = new Peso(peso.GetCantidad() + ((Peso)euro).GetCantidad());
            return retorno;
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            Peso retorno = new Peso(peso.GetCantidad() - ((Peso)euro).GetCantidad());
            return retorno;
        }

        #endregion

    }



}
