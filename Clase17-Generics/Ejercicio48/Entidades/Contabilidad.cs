using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T, U> where T : Documento where U:Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        #region Sobrecargas

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad, T egreso)
        {
            contabilidad.egresos.Add(egreso);
            return contabilidad;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad, U ingreso)
        {
            contabilidad.ingresos.Add(ingreso);
            return contabilidad;
        }
        #endregion

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach(T egreso in this.egresos)
            {
                sb.AppendLine(egreso.ToString());
            }
            foreach(U ingreso in this.ingresos)
            {
                sb.AppendLine(ingreso.ToString());
            }
            
            return sb.ToString();           
        }

    }
}
