using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Class1
    {        
        public enum Estaciones
        {
            Verano,
            Primavera,
            Invierno,
            Otonio
        }

        public static string ObtenerPlacaCronica(this DateTime instanciaDateTime, Estaciones estacion)
        {
            DateTime fechaAComparar;

            switch (estacion)
            {
                case Estaciones.Verano:
                    fechaAComparar = Convert.ToDateTime("21/12/19");
                    break;
                case Estaciones.Primavera:
                    fechaAComparar = Convert.ToDateTime("21/09/20");
                    break;
                case Estaciones.Invierno:
                    fechaAComparar = Convert.ToDateTime("21/06/20");
                    break;
                /*case Estaciones.Otonio:
                    fechaAComparar = Convert.ToDateTime("21/03/19");
                    break;*/
                default:
                    fechaAComparar = Convert.ToDateTime("21/03/20");
                    break;
            }

            TimeSpan tiempoFaltante = fechaAComparar - instanciaDateTime;
            string retorno = string.Format("Faltan {0} dias para el {1}", tiempoFaltante.Days, estacion.ToString());
            return retorno;            
        }

    }
}
