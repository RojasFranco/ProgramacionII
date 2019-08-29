using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool flag = true;
            int numero;   
            
            while(flag)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero>0)
                {
                    flag = false;
                    Console.WriteLine("Cuadrado: {0}", Math.Pow(numero, 2));
                    Console.WriteLine("Cubo: {0}", Math.Pow(numero, 3));
                }
                else
                {
                    Console.WriteLine("ERROR, ingrese nro nuevamente:");
                }
            }
            
            Console.ReadKey();            
        }
    }
}
