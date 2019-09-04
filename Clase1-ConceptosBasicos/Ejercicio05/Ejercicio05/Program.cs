using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaAnteriores;
            int sumaPosteriores;

            Console.Write("Ingrese numero:");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<numeroIngresado;i++)
            {
                sumaAnteriores = 0;
                sumaPosteriores = 0;
                for(int j=1; j<i; j++)                
                {
                    sumaAnteriores += j;                    
                }
                for(int k=i+1; sumaPosteriores<sumaAnteriores; k++)//mientras los post sean menor a ant
                {
                    sumaPosteriores += k;                    
                    if (sumaAnteriores == sumaPosteriores)
                    {
                        Console.WriteLine("{0} es centro numerico", i);
                    }
                }
                /* Tambien podria usarlo aca                 
                if(sumaAnteriores==sumaPosteriores)
                {
                    Console.WriteLine("{0} es centro numerico", i);
                }*/
            }
            Console.ReadKey();
        }
    }
}
