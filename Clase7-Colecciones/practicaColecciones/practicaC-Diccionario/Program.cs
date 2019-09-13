using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaC_Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un diccionario.
             Cargarlo con 5 dni como claves (string),
             y nombre y apellido de una persona como valor (string).
             Recorrer y mostrar en una cada clave almacenada
             junto con su valor.
             * 
             */

            Dictionary<string, string>diccionario = new Dictionary<string, string>();

            diccionario["111111"] = "Juan Perez";
            diccionario["333333"] = "Martin Benitez";
            diccionario["222222"] = "Pedro Martinez";
            diccionario["444444"] = "Lucas Cruz";            
            diccionario["555555"] = "Fede Rodriguez";
            diccionario.Add("666666","Carlos Alena");
                        
            foreach (string clave in diccionario.Keys)
            {
                Console.WriteLine("{0} {1}", clave, diccionario[clave]);
            }
            Console.ReadKey();
        }
    }
}
