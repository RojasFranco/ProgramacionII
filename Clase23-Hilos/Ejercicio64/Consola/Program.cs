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
        /*

            Los threads destinados a atender a los clientes deberán tener 
            en su propiedad “Name” el nombre de la caja que está atendiendo. 
         c. Se deberán iniciar los 3 threads uno a continuación del otro. 
         d. Utilizar el método Join del objeto de la clase Thread para asegurar 
            que se hayan asignado todos los clientes a alguna caja antes de comenzar a atender           
         */
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1, caja2);

            Thread hiloAsignarCajaACliente = new Thread(new ThreadStart(negocio.AsignarCaja));
            
            Thread hiloPrimerCaja = new Thread(new ThreadStart(caja1.AtenderCliente));
            hiloPrimerCaja.Name = "caja1";
            Thread hiloSegundaCaja = new Thread(new ThreadStart(caja2.AtenderCliente));
            hiloSegundaCaja.Name = "caja2";

            hiloAsignarCajaACliente.Start();
            Thread.Sleep(5000);
            hiloPrimerCaja.Start();
            hiloSegundaCaja.Start();
            

            Console.ReadKey();
        }
    }
}
