using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Threading;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1, caja2);

            //Thread primerHilo = new Thread( nre )
        }
    }
}
