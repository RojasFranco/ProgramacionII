using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;


        #region Constructores

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            // puesto            
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion




        /*public Cliente Cliente
        {
            get
            {

            }

            set
            {

            }
        }*/


        #region Sobrecargas

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            if(negocio.clientes.Contains(cliente))
            {
                return true;
            }
            return false; // return negocio.clientes.Contains(cliente)
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }


        #endregion
    }



}
