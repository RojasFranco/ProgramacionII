using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        #region Propiedades

        public int NumeroActual
        {
            get
            {
                return numeroActual;
            }
        }
        #endregion


        #region Enumerados
        public enum Puesto
        {
            Caja1,
            Caja2,
        }
        #endregion        


        #region Constructores

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        #endregion

        /// Falta
        #region Metodos
        /*public bool AtenderCliente(Cliente cliente)
        {

        }*/
        #endregion




    }
}
