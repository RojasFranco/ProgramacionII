using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar misDolares = new Dolar(1443);
            Peso misPesos = new Peso(80000,0.016);

            Peso totalPesos = misPesos + misDolares;

            //Peso totalPesos = misDolares + misPesos;


            Console.WriteLine("ASD:{0}", totalPesos.GetCantidad());

            Console.ReadKey();

            




        }
    }
}
