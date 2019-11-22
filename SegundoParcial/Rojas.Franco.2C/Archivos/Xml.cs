using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {        
        public string GetDirectoryPath
        {
            get { return (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\"); }
        }

        public bool FileExists(string nombreArchivo)
        {
            string archivoABuscar = this.GetDirectoryPath + nombreArchivo;
            if(File.Exists(archivoABuscar))
            {
                return true;
            }
            return false;
        }

        public void Guardar(string nombrearchivo, T objeto)
        {
            this.Guardar(nombrearchivo, objeto, Encoding.UTF8);
        }
        
        public void Guardar(string nombrearchivo, T objeto, Encoding encoding)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(this.GetDirectoryPath + nombrearchivo, encoding);
                XmlSerializer serializador = new XmlSerializer(typeof(T));                
                serializador.Serialize(writer, objeto);                
            }
            catch(Exception error)
            {
                throw new ErrorArchivosException("Error al crear archivo", error);
            }            
            finally
            {                         
                //writer.close();                
            }
        }
        
        public bool Leer(string nombrearchivo, out T objeto)
        {
            return this.Leer(nombrearchivo, out objeto, Encoding.UTF8);
        }

        public bool Leer(string nombrearchivo, out T objeto, Encoding encoding)
        {
            bool retorno = false;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                XmlTextReader reader = new XmlTextReader(nombrearchivo);
                objeto = (T)serializador.Deserialize(reader);
                retorno = true;               
            }
            catch(Exception err)
            {
                throw new ErrorArchivosException("Error al leer", err);                
            }
            finally
            {
                //return retorno;   
                //reader.Close();                
            }
            return retorno;
        }

    
    }
}

