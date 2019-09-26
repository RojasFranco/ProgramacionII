using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private double basee;
        private double altura;

        public Rectangulo(double basee, double altura)
        {
            this.basee = basee;
            this.altura = altura;
        }

        public override string MetodoDibujar()
        {
            return "Dibujando rectangulo..";
        }

        public override double CalcularSuperficie()
        {
            return basee * altura;
        }

        public override double CalcularPerimetro()
        {
            return basee + altura;
        }
    }
}
