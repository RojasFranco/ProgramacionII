using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class GuardarTexto<T, V> : IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            string textoRetorno = "Texto leido";
            V retorno;

            retorno = (V)Convert.ChangeType(textoRetorno, typeof(V));
            return retorno;
        }
    }
}
