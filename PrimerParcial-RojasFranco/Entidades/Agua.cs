using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;       

        #region Metodos

        /// <summary>
        /// Constructor Agua
        /// </summary>
        /// <param name="capacidadML">capacidad botella</param>
        /// <param name="marca">marca botella</param>
        /// <param name="contenidoML">contenido botella</param>
        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
        }

        /// <summary>
        /// Sirve medida, devuelve cantidad restante en contenido
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            /*if(MEDIDA<=this.Contenido)
            {
                return (this.Contenido - MEDIDA);
            }
            else
            {
                return (this.Contenido - this.Contenido);
            }*/

          int retorno = this.ServirMedida(MEDIDA);
          return retorno;
        }

        /// <summary>
        /// Sirve medida, devuelve cantidad restante en contenido
        /// </summary>
        /// <param name="medida">medidad a servir</param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {
            if(medida <= this.Contenido)
            {
                return (this.Contenido - medida);
            }
            else
            {
                return (this.Contenido - this.Contenido);
            }            
        }





        /// <summary>
        /// Informe con todos los atributos de agua
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GenerarInforme());
            sb.AppendFormat("\n Medida: {0}", MEDIDA);

            return sb.ToString();
        }


        #endregion


    }
}
