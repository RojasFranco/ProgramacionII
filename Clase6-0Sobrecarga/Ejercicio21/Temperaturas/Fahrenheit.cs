using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private double cantidadGrados;
        //private static ConversionFahrenhetCelsius;


        #region Constructores

        public Fahrenheit(double cantidadGrados)
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

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            double gradosCelsius = (fahrenheit.GetCantidadGrados() - 32) * 5 / 9;
            Celsius retorno = new Celsius(gradosCelsius);
            return retorno;
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            double gradosKelvin = (fahrenheit.GetCantidadGrados() + 459.67) * 5 / 9;

            Kelvin retorno = new Kelvin(gradosKelvin);
            return retorno;
        }

        #endregion


        #region Sobrecargas operaciones

        public static Fahrenheit operator +(Fahrenheit fahrenheit, Celsius celsius)
        {
            Fahrenheit retorno = new Fahrenheit(fahrenheit.GetCantidadGrados() + ((Fahrenheit)celsius).GetCantidadGrados());
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheit, Celsius celsius)
        {
            Fahrenheit retorno = new Fahrenheit(fahrenheit.GetCantidadGrados() - ((Fahrenheit)celsius).GetCantidadGrados());
            return retorno;
        }


        public static Fahrenheit operator +(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            Fahrenheit retorno = new Fahrenheit(fahrenheit.GetCantidadGrados() + ((Fahrenheit)kelvin).GetCantidadGrados());
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            Fahrenheit retorno = new Fahrenheit(fahrenheit.GetCantidadGrados() - ((Fahrenheit)kelvin).GetCantidadGrados());
            return retorno;
        }

        #endregion

    }
}
