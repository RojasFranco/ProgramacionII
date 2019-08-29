using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInicial;
            int numeroFinal;

            Console.Write("Ingrese numero inicial:");
            numeroInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese numero Final:");
            numeroFinal = Convert.ToInt32(Console.ReadLine());

            for(int i=numeroInicial; i<numeroFinal; i++)
            {
                if(i % 4 == 0 || (i % 100 == 0 && i % 400 == 0))
                {
                    Console.WriteLine("{0} es año bisiesto", i);
                }
            }
            Console.ReadKey();
        }
    }
}

