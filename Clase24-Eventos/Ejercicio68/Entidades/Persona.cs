using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;        

        public event DelegadoString EventoString;

        #region Propiedades

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = value;
                if (EventoString != null)
                {
                    EventoString.Invoke("Se creo apellido");
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {                
                if(EventoString!=null)
                {
                    EventoString.Invoke("Se creo nombre");
                }
                this.nombre = value;
            }
        }

        #endregion

        public Persona()
        {
            //this.nombre = "Franco";
            //this.apellido = "Rojas";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} - Apellido {1}\n", this.Nombre, this.Apellido);

            return sb.ToString();
        }



    }
}
