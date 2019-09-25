using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro();

            miLibro[3] = "Primer pagina";

            Console.WriteLine("\nMuesto pagina inexistente: {0}", miLibro[2]);

            Console.WriteLine("\nMuesto pagina existente: {0}", miLibro[0]);


            //Reemplazo primer pag

            miLibro[0] = "Reemplazada";
            Console.WriteLine("\n muestro reemplazo : {0}", miLibro[0]);

            Console.ReadKey();            



        }
    }
}
