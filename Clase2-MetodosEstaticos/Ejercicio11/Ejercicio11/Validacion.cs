using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Validacion
    {
        /*No se usan en este caso, no son atributos. son datos que recibe una funcion
         * 
         * public int valor;
        public int min;
        public int max;
        public bool esValido;*/
        public static bool Validar(int valor, int min, int max)
        {
            if(valor<max && valor>min)
            {
                return true;
            }
            return false;
        }            
    }
}
