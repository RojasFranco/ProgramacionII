using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100; //const Para constantes
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if (tinta>=0 && tinta<=cantidadTintaMaxima)
            {
                // OK
                //this.tinta = tinta;
            }
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            SetTinta(gasto);
            dibujo = "";
            return true;
        }        

    }
}
