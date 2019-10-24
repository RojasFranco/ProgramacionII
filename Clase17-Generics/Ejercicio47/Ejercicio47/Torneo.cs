using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        #region Sobrecargas

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach(T equipoEnTorneo in torneo.equipos)
            {
                if(equipoEnTorneo==equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo) //No es equipo porque puede ser EqFut o EqBasq
        {
            if(torneo==equipo)
            {
                return torneo;
            }
            torneo.equipos.Add(equipo);
            return torneo;
        }

        #endregion

        #region Metodos


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            foreach(T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }
            return sb.ToString();
        }


        private string CalcularPartido(T equipo1, T equipo2)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            sb.AppendFormat(" {0}:{1} - {2}:{3} ", equipo1.Nombre, random.Next(10), equipo2.Nombre, random.Next(10) );
            return sb.ToString();
        }

        #endregion

        public string JugarPartido
        {
            get
            {
                return CalcularPartido(this.ObtenerEquipoAzar(), this.ObtenerEquipoAzar());
            }
        }

        public T ObtenerEquipoAzar()
        {
            Random random = new Random();
            int cantidadEquipos=0;
            
            if(this.equipos.Count>0)
            {
                cantidadEquipos = this.equipos.Count;
            }

            System.Threading.Thread.Sleep(80); //PAra que cambie el equipo(por Random)
            return (this.equipos[random.Next(0, cantidadEquipos)]);
        }


    }
}
