using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MetodoExtension
    {
        public static int ContarSignos(this string instancia)
        {
            string signosAContar = ",.;";
            int retorno = 0;
            
            foreach(Char caracter in instancia)
            {
                if(signosAContar.Contains(caracter))
                {
                    retorno += 1;
                }
            }
            return retorno;
        }
    }
}
