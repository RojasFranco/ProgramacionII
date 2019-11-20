using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }

        public void AtenderCliente()
        {
            //El método AtenderClientes deberá recorrer la fila de clientes e ir imprimiendo el nombre del
            //cliente que se está atendiendo junto con el número de caja que será previamente seteado
            //en la propiedad "Name" del thread.
            //Por cada cliente que se atiende en cada caja se tardará 2 segundos            
            foreach (string nombreCliente in this.FilaClientes)
            {
                Thread.Sleep(2000);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Cliente: {0}",nombreCliente);
                Console.WriteLine("Caja: {0}", Thread.CurrentThread.Name);                                                
            }
        }
    }
}
