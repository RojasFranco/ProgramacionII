using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int contador;
            Console.Write("Ingrese numero:");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());                
            for(int i=2; i<=numeroIngresado; i++)
            {
                contador = 0;                
                for (int j=2; j<i/*numeroIngresado*/; j++)
                {                    
                    if (i%j==0)
                    {
                        contador+=1;
                        break;
                    }                    
                }
                //Console.WriteLine("A: {0}", i);
                if (contador==0)
                {
                    Console.WriteLine("{0} es nro primo", i);
                }

            }
            Console.ReadKey();           
        }
    }
}
