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
            int numero;
            double acumulador=0;
            int max=0;
            int min=0;

            for(int i=0; i<5; i++)
            {
                Console.Writeline("Ingrese un nro:");
                numero = Convert.ToInt32(Console.ReadLine());

                if(i==0)
                {
                    max = numero;
                    min = numero;
                }
                else if(numero>max)
                {
                    max = numero;                    
                }
                else if(numero<min)
                {
                    min = numero;
                }
                acumulador += numero;
            }

            Console.WriteLine("Maximo: {0}", max);
            Console.WriteLine("Minimo: {0}", min);
            Console.WriteLine("Promedio: {0}", acumulador/5.0);

            Console.ReadKey();
        }
    }
}
