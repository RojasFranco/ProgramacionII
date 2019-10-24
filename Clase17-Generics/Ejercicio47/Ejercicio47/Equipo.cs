using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }


        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            if(equipo1.Nombre==equipo2.Nombre && equipo1.FechaCreacion == equipo2.FechaCreacion)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }


        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0} fundado en {1} ", this.Nombre, this.FechaCreacion);
            return sb.ToString();
        }
    }
}
