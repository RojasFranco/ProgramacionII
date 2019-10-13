using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;



        #region Propiedades

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        #endregion

        #region Metodos

        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
            this.botellas = new List<Botella>();
        }

        public static Cantina GetCantina(int espacios)
        {
            if(singleton==null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }

        public static bool operator +(Cantina cantina, Botella botella)
        {
            if(cantina.Botellas.Count < cantina.espaciosTotales)
            {
                cantina.Botellas.Add(botella);
                return true;
            }

            return false;
        }

        #endregion
    }
}
