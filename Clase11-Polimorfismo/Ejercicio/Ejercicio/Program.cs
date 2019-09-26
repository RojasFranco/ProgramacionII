using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(2));

            figuras.Add(new Cuadrado(3));
            figuras.Add(new Rectangulo(4, 8));


            foreach(Figura miFigura in figuras)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine(miFigura.MetodoDibujar());
                Console.WriteLine("Superficie: {0 : 0.00}", miFigura.CalcularSuperficie());
                Console.WriteLine("Perimetro: {0 : 0.00}", miFigura.CalcularPerimetro());
                Console.WriteLine("Tipo: {0}", miFigura.GetType());
            }

            Console.ReadKey();
        }
    }
}
