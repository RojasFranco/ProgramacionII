using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            int diasDelAnio;
            int diaActual;
            int mesActual;

            Console.Write("Ingrese dia de nacimiento:");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese mes de nacimiento:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese año de nacimiento:");
            anio = Convert.ToInt32(Console.ReadLine());

            //DateTime.Now.Year devuelve el año actual;
            for (int i=anio; i<= DateTime.Now.Year; i++)
            {
                if(i%4==0 || (i%100==0 && i%400==0))
                {
                    diasDelAnio = 366;
                }
                else
                {
                    diasDelAnio = 365;
                }
                
            }

            Console.ReadKey();            
        }
    }
}
