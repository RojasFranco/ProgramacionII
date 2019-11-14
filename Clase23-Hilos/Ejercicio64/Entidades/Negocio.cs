using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private List<string> clientes;
        private Caja caja1;
        private Caja caja2;

        #region Propiedades

        public Caja Caja1
        {
            get { return this.caja1; }
        }

        public Caja Caja2
        {
            get { return this.caja2; }
        }

        public List<string> Clientes
        {
            get { return this.clientes; }
        }

        #endregion

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
            this.clientes.Add("Cliente A");
            this.clientes.Add("Cliente B");
            this.clientes.Add("Cliente C");
            this.clientes.Add("Cliente D");
        }

        public void AsignarCaja()
        {
            //El método AsignarCaja deberá imprimir el mensaje "Asignando cajas..." cuando sea
            //invocado, recorrer la lista de clientes y asignar a cada cliente en la fila de la caja que menos
            //clientes tenga en ese momento . Debera tardar 1 segundo
        }

    }
}
