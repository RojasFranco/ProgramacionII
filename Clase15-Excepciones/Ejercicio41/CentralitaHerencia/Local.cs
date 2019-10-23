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

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)//this(new Llamada(duracion, destino, origen), costo)
        {
            this.costo = costo;
        }

        //O puedo intercambiar lugar del base con this

        #endregion


        #region Metodos

        private float CalcularCosto()
        {
            return (this.costo * this.Duracion);
        }
        

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine("\n-------LLamada local---------");
            sb.Append(base.Mostrar());
            sb.AppendFormat("\n Costo llamada: {0: 0.00} ", this.CostoLlamada); //Formato para que muestre x.xx
            return sb.ToString();
        }
                
        
        public override bool Equals(object obj)
        {
            if(obj is Local) // O obj.GetType() == typeof(Local)
            {
                return true;
            }
            return false;            
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

    }
}
