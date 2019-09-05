using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Obs Sobrecarga de operador debe ser estatico
//refer click derecho agregar ref->proyectos->elegir . luego usar using

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Probando sobrecargas de operadores
             * 
            Producto p1 = new Producto("pp", "02", 25);

            Producto p2 = new Producto("qq", "03", 22);

            Producto p3 = new Producto("pp", "02", 25);


            bool Prueba = p1 != p3;
            Console.WriteLine("ESTEM: {0}", Prueba);

            bool pruebaDos = p1 == p2;
            Console.WriteLine("P.Dos {0}", pruebaDos);

            bool pruebaTres = p1 == p3;
            Console.WriteLine("P.Tres {0}", pruebaTres);

            */


            //Console.WriteLine(Producto.MostrarProducto(p1));



            /**
             * SOBRECARGA EXPLICITA
             * Para accede a codigo desde afuera, ya que es private
            string codigo = (string) p1;
            Console.WriteLine("A: {0}", codigo);
            */



            /*
             * sobrecarga implicita
             * 
            Producto p10 = new Producto("taverniti", "00", 23);

            float precioEquis = p10;
            Console.WriteLine("--- : {0}", precioEquis);
            */

            Console.ReadKey();
        }
    }
}
