using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        #region Propiedades

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return (this.GananciaPorLocal + this.GananciaPorProvincial);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Constructores

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion


        #region Metodos

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float costoLocal = 0;
            float costoProvincial = 0;
            
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if(llamada is Local) // o (llamada.GetType() == typeof(Local)) 
                {
                    costoLocal += ((Local)llamada).CostoLlamada;
                }
                else if(llamada is Provincial)
                {
                    costoProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }    
            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return costoLocal;
                case Llamada.TipoLlamada.Provincial:
                    return costoProvincial;
                default:
                    return (costoProvincial + costoLocal);                
            }            
        }



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n Razon social: {0}\n ", this.razonSocial);
            sb.AppendFormat(" Ganancia total: {0}\n ", this.GananciaPorTotal);
            sb.AppendFormat(" Ganancia Local: {0}\n ", this.GananciaPorLocal);
            sb.AppendFormat(" Ganancia Provincial: {0}\n ", this.GananciaPorProvincial);   
            foreach(Llamada llamada in Llamadas) //Llamadas= this.listaLlamadas
            {
                if(llamada is Local)
                {
                    sb.Append(((Local)llamada).Mostrar());
                }
                else if(llamada is Provincial)
                {
                    sb.Append(((Provincial)llamada).Mostrar());
                }
            }
            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {            
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);// VER            
        }

        #endregion

    }
}
