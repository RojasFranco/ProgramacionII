using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191121_SP
{
    public static class MetodoExtension
    {
        public static string EstadoSimulacion(this string instancia, bool booleano)
        {
            if(booleano)
            {
                return "Orbitando";
            }
            return "Detenido";
        }
    }
}
