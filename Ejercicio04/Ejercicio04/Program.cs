using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosEncontrados=0;
            int sumaDivisores;

            for(int i=0; numerosEncontrados<4; i++)
            {
                sumaDivisores = 0;

                for(int j=i-1; j>0; j--)
                {
                    if(i%j == 0)
                    {
                        sumaDivisores += j;
                    }

                }

                if(sumaDivisores==i && sumaDivisores>0)
                {
                    Console.WriteLine("Nro perfecto: {0}", i);
                    numerosEncontrados++;
                }


            }
            Console.ReadKey();
        }
    }
}
