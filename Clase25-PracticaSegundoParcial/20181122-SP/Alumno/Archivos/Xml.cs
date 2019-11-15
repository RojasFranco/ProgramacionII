using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                serializador.Serialize(writer, datos);
            }
        }

        public void Leer(string archivo, out T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                datos = (T)serializador.Deserialize(reader);
            }
        }
    }
}
