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
            /*PuestoAtencion.Puesto mpuesto = PuestoAtencion.Puesto.Caja1;
            int i = (int)mpuesto;
            Console.WriteLine(i);
            Console.WriteLine(mpuesto);*/


            Negocio supermercado = new Negocio("supermerk2");

            Cliente cliente1 = new Cliente(1, "Franco");
            Cliente cliente2 = new Cliente(2, "Leo");
            Cliente cliente3 = new Cliente(3, "Pepe");

            Cliente auxDesencolado;
            
            if(supermercado+cliente1) //supermercado.Cliente = cliente1;
            {
                //Console.WriteLine(supermercado.Cliente.Nombre);
                auxDesencolado = supermercado.Cliente;
                Console.WriteLine("\n Desencolado : {0}", auxDesencolado.Nombre);

            }

            Console.WriteLine("\n Clientes pendientes: {0}",supermercado.ClientesPendientes);

            // Encolamos 2

            supermercado.Cliente = cliente2;
            supermercado.Cliente = cliente3;

            Console.WriteLine("\n Clientes pendientes: {0}", supermercado.ClientesPendientes);

            //Encolamos un repetido y vemos si lo agrega

            supermercado.Cliente = cliente2;
            Console.WriteLine("\n Clientes pendientes: {0}", supermercado.ClientesPendientes);

            // Realizamos una atencion

            if (~supermercado)
            {                
                Console.WriteLine("\n Clientes pendientes: {0}", supermercado.ClientesPendientes);                
            }



            Console.ReadKey(); 
        }
    }
}
