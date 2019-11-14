using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string apellido;
        private string nombre;

        public delegate void DelegadoString(string msg);

        public event DelegadoString EventoString;

        #region Propiedades

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = value;                
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = value;
                if(EventoString!=null)
                {
                    EventoString.Invoke("Se creo nombre");
                }                
            }
        }

        #endregion

        public Persona()
        {
            this.nombre = "Franco";
            this.apellido = "Rojas";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} - Apellido {0}\n", this.Nombre, this.Apellido);

            return sb.ToString();
        }



    }
}
