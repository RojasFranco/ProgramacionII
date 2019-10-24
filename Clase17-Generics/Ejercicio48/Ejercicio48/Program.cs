using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            Factura factura = new Factura(37350);
            Recibo recibo = new Recibo(28299);

            contabilidad = contabilidad + factura;
            contabilidad += recibo;

            Console.WriteLine(contabilidad.Mostrar());

            Console.ReadKey();
        }
    }
}
