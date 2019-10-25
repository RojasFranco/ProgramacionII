using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string textoRetorno = "Objeto leido";
            V retorno;

            retorno = (V)Convert.ChangeType(textoRetorno, typeof(V));
            return retorno;
        }
    }
}
