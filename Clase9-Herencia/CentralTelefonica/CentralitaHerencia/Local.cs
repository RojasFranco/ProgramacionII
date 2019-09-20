using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;


        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;                        
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {            
        }

        //O puedo intercambiar lugar del base con this

        #endregion


        #region Metodos

        private float CalcularCosto()
        {
            return (this.costo * this.Duracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------LLamada local---------");
            sb.Append(base.Mostrar());
            sb.AppendFormat(" Costo llamada: {0: 0.00} ", this.CostoLlamada); //Formato para que muestre x.xx
            return sb.ToString();
        }

        #endregion

    }
}
