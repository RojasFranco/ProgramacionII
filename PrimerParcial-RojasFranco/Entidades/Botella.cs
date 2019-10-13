using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;


        #region Propiedades


        /// <summary>
        /// Propiedad devuelve capacidad en litros
        /// </summary>
        public int CapacidadLitros
        {
            get
            {
                return (this.capacidadML / 1000);
            }
        }

        /// <summary>
        /// Propiedad, devuelve contenido, o asigna valor a éste atributo
        /// </summary>
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        /// <summary>
        /// Devuelve porcentaje del contenido
        /// </summary>
        public float PorcentajeContenido
        {
            get
            {
                return ( (this.Contenido * 100) / (this.CapacidadLitros * 1000));
            }
        }
        #endregion


        #region Metodos

        /// <summary>
        /// Constructor botella
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="capacidadLM">capacidad de botella</param>
        /// <param name="contenidoML">contenido de botella</param>
        protected Botella(string marca, int capacidadLM, int contenidoML)
        {            
            if (capacidadLM<contenidoML)
            {
                this.Contenido = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }

            this.capacidadML = capacidadLM;
            this.marca = marca;            
        }

        /// <summary>
        /// Genera informe con todos los atributos de botella
        /// </summary>
        /// <returns></returns>
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n Capacidad: {0}", (this.CapacidadLitros) * 1000);
            sb.AppendFormat("\n Contenido: {0}", this.Contenido);
            sb.AppendFormat("\n Marca: {0}", this.marca);

            return sb.ToString();
        }

        public abstract int ServirMedida();

        /// <summary>
        /// Devuelve Informe
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GenerarInforme();
        }

        #endregion


        public enum Tipo
        {
            Plastico,
            Vidrio
        }

    }
}
