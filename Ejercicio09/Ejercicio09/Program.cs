using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string asteriscos;
            altura = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<altura+1; i++)
            {
                asteriscos = "*";
                if (i==1)
                {
                    Console.WriteLine("*");
                    continue;
                }                
                for (int j = 2; j <= i; j++)
                {
                    asteriscos += "**";
                    //Console.WriteLine("{0}", asteriscos);
                }
                Console.WriteLine("{0}", asteriscos);
            }
            
            Console.ReadKey();
        }
    }
}
