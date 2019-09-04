using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Alumno alumnoUno = new Alumno("Juan", "Perez", 100);
            Alumno alumnoDos = new Alumno("Pedro", "Cruz", 120);
            Alumno alumnoTres = new Alumno("Jose", "Rodriguez", 140);
            
            alumnoUno.Estudiar(3, 8);
            alumnoDos.Estudiar(4, 6);
            alumnoTres.Estudiar(4, 6);
            /*Console.Write("Ingrese nota uno:");
            notaUno = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese nota Dos:");
            notaDos = byte.Parse(Console.ReadLine());*/

            //alumnoUno.Estudiar(notaUno, notaDos);
            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            // Puedo usar   Console.Write("Obs {0}", alumnoUno.Mostrar()); 


            Console.WriteLine(alumnoUno.Mostrar());

            Console.WriteLine(alumnoDos.Mostrar());

            Console.WriteLine(alumnoTres.Mostrar());           
           

            Console.ReadKey();
        }
    }
}
