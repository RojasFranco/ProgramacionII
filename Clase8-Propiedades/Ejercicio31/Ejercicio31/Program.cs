using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            PuestoAtencion.Puesto mpuesto = PuestoAtencion.Puesto.Caja1;
            int i = (int)mpuesto;
            Console.WriteLine(i);
            Console.WriteLine(mpuesto);
            Console.ReadKey(); 
        }
    }
}
