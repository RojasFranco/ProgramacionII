using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        #region Propiedades
        
        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Magenta;
            }
            set
            {
                throw new NotImplementedException("Error set lapiz");
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        #endregion


        #region Constructor

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }

        #endregion

        #region Metodos

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, this.Color);
            float cantidadCaracteresEscritos = texto.Length;
            this.UnidadesDeEscritura -= (cantidadCaracteresEscritos * (float)0.1);

            return retorno;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException("Err en lapiz.Recargar");
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lapiz");
            sb.AppendFormat("Color tinta: {0}\n", this.Color);
            sb.AppendFormat("tamaño mina: {0}\n", this.UnidadesDeEscritura);


            return sb.ToString();
        }

        #endregion





    }

}
