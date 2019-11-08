using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {            
            DateTime fechaActual = DateTime.Now;
            string retorno = fechaActual.ObtenerPlacaCronica(Class1.Estaciones.Invierno);
            Console.WriteLine(retorno);             
            Console.ReadKey();
        }
    }
}
