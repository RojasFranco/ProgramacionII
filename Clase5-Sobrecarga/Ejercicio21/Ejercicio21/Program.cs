using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {

            Celsius gradosPrueba = new Celsius(22);

            Fahrenheit pruebaConversion = (Fahrenheit)gradosPrueba;

            Console.WriteLine("ASDASD: {0}", pruebaConversion.GetCantidadGrados());

            Console.ReadKey();








        }
    }
}
