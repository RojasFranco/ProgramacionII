using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;


        #region Metodos

        /// <summary>
        /// Constructor de cerveza
        /// </summary>
        /// <param name="capacidadML">capacidad</param>
        /// <param name="marca">marca</param>
        /// <param name="contenidoML">contenido</param>
        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacidadML">capacidad</param>
        /// <param name="marca">marca</param>
        /// <param name="tipo">tipo botella</param>
        /// <param name="contenidoML">contenido</param>
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sirve medida, retorna el contenido restante
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            if (MEDIDA <= this.Contenido)
            {
                return (this.Contenido - (MEDIDA*80/100));
            }
            else
            {
                return (this.Contenido - (this.Contenido*80/100));
            }
        }


        /// <summary>
        /// convierte cerveza implicitamente a su tipo de botella
        /// </summary>
        /// <param name="cerveza"></param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            /*  ----------------------IMPORTANTE--------------------------------------
             *  ¿Por que no funciona??
             *  No funciona porque el cerveza is __ buscaria CLASES derivadas de cerveza(NO ENUM. Por ej 40)
             *  Serviria si tendria que buscar si una botella es cerveza o agua
             * 
             * if(cerveza.GetType().Name == Tipo.Vidrio.ToString() )
            {
                return Tipo.Vidrio;
            }
            return Tipo.Plastico;*/                       

            return cerveza.tipo;
        }
        

        /// <summary>
        /// Informa todos los atributos de cerveza
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
