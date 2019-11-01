using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    [Serializable]
    public class PersonaParaBinario
    {
        private string nombre;
        private string apellido;

        public PersonaParaBinario(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        public static void GuardarBinario(string file, PersonaParaBinario persona)
        {
            FileStream fileStream = new FileStream(file, FileMode.Create);
            BinaryFormatter serializador = new BinaryFormatter();

            serializador.Serialize(fileStream, persona);
            fileStream.Close();
        }

        public static PersonaParaBinario LeerBinario(string file)
        {
            BinaryFormatter serializador = new BinaryFormatter();
            FileStream fileStream = new FileStream(file, FileMode.Open);


            PersonaParaBinario personaRetornar = (PersonaParaBinario)serializador.Deserialize(fileStream);
            return personaRetornar;

        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" Nombre: {0} \n", this.nombre);
            sb.AppendFormat(" Apellido: {0} \n", this.apellido);

            return sb.ToString();
        }
    }
}
