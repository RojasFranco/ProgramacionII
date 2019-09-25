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

        public static int NumeroActual
        {
            get
            {
                return numeroActual+1;
            }
        }
        #endregion


        #region Enumerados
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        #endregion        


        #region Constructores

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion

        /// Falta ESto
        #region Metodos
        public static bool AtenderCliente(Cliente cliente)
        {
            System.Threading.Thread.Sleep(3000);
            return true;
        }
        #endregion




    }
}
