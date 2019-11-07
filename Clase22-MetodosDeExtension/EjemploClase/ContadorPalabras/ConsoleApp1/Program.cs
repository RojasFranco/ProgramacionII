using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CambioParaTenerEjemploYExportar;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string miHolaMundo = "Hola mundo soy Franco";
            int cantidad = miHolaMundo.ContarPalabras();
            Console.WriteLine("Cantidad palabras: {0}", cantidad);

            Console.ReadKey();
        }
    }
}
