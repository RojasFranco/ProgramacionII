using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Llamada llam = new Llamada(2 , "4225", "1111");
            Console.WriteLine(llam.Mostrar());
            string pp = llam.NroDestino;
            
            Llamada.TipoLlamada asd = Llamada.TipoLlamada.Local;
            int i = (int)asd;

            Console.WriteLine(i);
            */

            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);            
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");            
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            /*
            c.Llamadas.Add(l1);            
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.OrdenarLlamadas();            
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            */
            Local l5 = new Local("Bernal", 30, "Rosario", 2.65f);

            if (l1==l5)
            {
                Console.WriteLine("ASDASD");
            }
            Console.ReadKey();
        }
    }
}
