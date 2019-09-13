using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        private double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #region Metodos

        public double GetCantidadGrados()
        {
            return this.cantidad;
        }

        #endregion

        #region Sobrecargas

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            Fahrenheit retorno = new Fahrenheit(celsius.GetCantidadGrados() * 9 / 5 + 32);
            return retorno;
        }


        public static explicit operator Kelvin(Celsius celsius)
        {
            Kelvin retorno = new Kelvin(celsius.GetCantidadGrados() + 273.15);
            return retorno;

        }

        #endregion


        #region Sobrecargas operaciones

        public static Celsius operator +(Celsius celsius, Fahrenheit fahrenheit)
        {
            Celsius retorno = new Celsius(celsius.GetCantidadGrados() + ((Celsius)fahrenheit).GetCantidadGrados());
            return retorno;
        }

        public static Celsius operator -(Celsius celsius, Fahrenheit fahrenheit)
        {
            Celsius retorno = new Celsius(celsius.GetCantidadGrados() - ((Celsius)fahrenheit).GetCantidadGrados());
            return retorno;
        }


        public static Celsius operator +(Celsius celsius, Kelvin kelvin)
        {
            Celsius retorno = new Celsius(celsius.GetCantidadGrados() + ((Celsius)kelvin).GetCantidadGrados());
            return retorno;
        }

        public static Celsius operator -(Celsius celsius, Kelvin kelvin)
        {
            Celsius retorno = new Celsius(celsius.GetCantidadGrados() - ((Celsius)kelvin).GetCantidadGrados());
            return retorno;
        }


        #endregion

        //public 
    }
}
