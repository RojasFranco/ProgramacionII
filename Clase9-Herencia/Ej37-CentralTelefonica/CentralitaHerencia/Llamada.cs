using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;


        #region Propiedades

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion


        #region Constructor

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;            
        }

        #endregion


        #region Metodos

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n Duracion : {0}", this.Duracion);
            sb.AppendFormat("\n Nro destino: {0} ", this.NroDestino);
            sb.AppendFormat("\n Nro origen: {0}", this.NroOrigen);
            return sb.ToString();            

        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.Duracion<llamada2.Duracion)
            {
                return -1;
            }
            else if(llamada1.Duracion == llamada2.Duracion)
            {
                return 0;
            }
            return 1;
        }

        #endregion

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
