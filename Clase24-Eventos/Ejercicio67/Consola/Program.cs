using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Temporizador pruebaTemporizador = new Temporizador();
            
            pruebaTemporizador.Intervalo = 1000;
            //pruebaTemporizador.Activo = true;

            //Temporizador.encargadoTiempo paraManejar = new Temporizador.encargadoTiempo(Manejador.Manejar);            
            //pruebaTemporizador.EventoTiempo += paraManejar;
            pruebaTemporizador.EventoTiempo += Manejador.Manejar;
            pruebaTemporizador.Activo = true;
            Thread.Sleep(4000);
            pruebaTemporizador.Activo = false;

            Console.ReadKey();
        }

    }
}
