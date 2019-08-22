using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Primera clase";
            Console.BackgroundColor = ConsoleColor.Blue;
            string nombre = "Franco";
            string apellido = "Rojas";
            Console.WriteLine("Hola {0} {1}!", nombre, apellido);

            Console.ReadKey();
        }
    }
}
