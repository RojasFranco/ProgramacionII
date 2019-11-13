using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class MetodoExtension
    {
        public static string CantidadDeDigitos(this string instancia)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Numero de:       {0} digitos\n", (instancia.Length));

            return sb.ToString();
        }
    }
}
