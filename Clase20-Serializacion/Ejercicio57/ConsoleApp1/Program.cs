using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // PARA SERIALIZACION XML

            Persona personaSerializar = new Persona("Pepe", "Argento");
            Console.WriteLine("-----------------------");
            Persona.Guardar(personaSerializar, "C:\\Users\\alumno\\Desktop\\archivoo.Xml");
            Console.WriteLine("Serealizando, presione tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("Deserealizando..");
            Console.WriteLine(Persona.Leer("C:\\Users\\alumno\\Desktop\\archivoo.Xml"));
            Console.ReadKey();



            // PARA SERIALIZACION BINARIA

            PersonaParaBinario personaSerializarBinaria = new PersonaParaBinario("nombreBinaria", "apellBinario");
            Console.WriteLine("-----------------------");
            PersonaParaBinario.GuardarBinario("C:\\Users\\alumno\\Desktop\\archivooBinario", personaSerializarBinaria);
            Console.WriteLine("Serializado, presione tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Deserealizando..");
            Console.WriteLine(PersonaParaBinario.LeerBinario("C:\\Users\\alumno\\Desktop\\archivooBinario"));
            Console.ReadKey();




        }
    }
}
