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
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);

        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion




        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }

            set //VERRRRR
            {
                bool retorno = this + value;
            }
        }


        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }



        #region Sobrecargas

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            if (negocio.clientes.Contains(cliente))
            {
                return true;
            }
            return false; // return negocio.clientes.Contains(cliente)
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }


        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            if (negocio != cliente)
            {
                negocio.clientes.Enqueue(cliente);
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ~(Negocio negocio)
        {
            Cliente clienteAgregar = negocio.Cliente;
            bool retorno = false;

            if(negocio != clienteAgregar)
            {
                PuestoAtencion.AtenderCliente(clienteAgregar);
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }



}
