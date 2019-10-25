using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAcciones
    {
        //Metodos
        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);
        
        //Propiedades
        ConsoleColor Color
        {
            get;
            set;
        }
        float UnidadesDeEscritura
        {
            get;
            set;
        }
    }
}
