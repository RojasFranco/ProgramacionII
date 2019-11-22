using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        #region Constructores

        public Persona() // Para poder serializar
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        #endregion

        public static void Guardar(Persona persona, string file)
        {
            XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8); // El que escribe
            XmlSerializer serializador = new XmlSerializer(typeof(Persona)); // El que serializa

            serializador.Serialize(writer, persona);
            writer.Close();                        
        }

        public static Persona Leer(string archivo)
        {
            XmlTextReader reader = new XmlTextReader(archivo);
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));
            Persona personaRetornar;

            personaRetornar = (Persona)serializador.Deserialize(reader);
            return personaRetornar;
        }


        #region Para leer

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" Nombre: {0} \n", this.nombre);
            sb.AppendFormat(" Apellido: {0} \n", this.apellido);

            return sb.ToString();
        }

        #endregion
    }
}
