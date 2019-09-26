using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed public class Cuadrado : Rectangulo
    {
        //private double basee; TAMPOCO HACE FALTA PORQUE YA LO TIENE DE RECTANGULO        
        public Cuadrado(double lado) : base(lado, lado)
        {
        }

        // NO HACEN FALTA REEMPLAZARLOS DE RECTANGULO PORQUE ES LO MISMO

        /*
        public override double CalcularSuperficie()
        {
            return base.CalcularSuperficie();
        }

        public override double CalcularPerimetro()
        {
            return base.CalcularPerimetro();
        }

        */
    }
}
