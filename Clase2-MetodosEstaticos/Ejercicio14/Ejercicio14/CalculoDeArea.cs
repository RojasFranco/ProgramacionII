using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {                

        public static double CalcularCuadrado(double numero)
        {
            return numero * numero;
        }
        public static double CalcularTriangulo(double altura, double basee)
        {
            return basee * altura / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }
}
