using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private double cantidadGrados;

        #region Constructores

        public Kelvin(double cantidadGrados)
        {
            this.cantidadGrados = cantidadGrados;
        }

        #endregion


        #region Metodos

        public double GetCantidadGrados()
        {
            return this.cantidadGrados;
        }

        #endregion

        #region Sobrecargas

        public static explicit operator Celsius(Kelvin kelvin)
        {
            Celsius retorno = new Celsius(kelvin.GetCantidadGrados() - 273.15);
            return retorno;
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            Fahrenheit retorno = new Fahrenheit(kelvin.GetCantidadGrados()*9/5 -459.67 );
            return retorno;
        }

        #endregion

        #region Sobrecargas operaciones

        public static Kelvin operator +(Kelvin kelvin, Celsius celsius)
        {
            Kelvin kelvinAuxiliar = (Kelvin)celsius;
            double cantidadAuxiliar = kelvinAuxiliar.GetCantidadGrados();

            Kelvin retorno = new Kelvin(kelvin.GetCantidadGrados() + cantidadAuxiliar);
            return retorno;
        }

        public static Kelvin operator -(Kelvin kelvin, Celsius celsius)
        {
            Kelvin retorno = new Kelvin(kelvin.GetCantidadGrados() + ((Kelvin)celsius).GetCantidadGrados() );
            return retorno;
        }

        public static Kelvin operator +(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            Kelvin retorno = new Kelvin(kelvin.GetCantidadGrados() + ((Kelvin)fahrenheit).GetCantidadGrados());
            return retorno;
        }

        public static Kelvin operator -(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            Kelvin retorno = new Kelvin(kelvin.GetCantidadGrados() - ((Kelvin)fahrenheit).GetCantidadGrados());
            return retorno;
        }
        #endregion

    }
}
