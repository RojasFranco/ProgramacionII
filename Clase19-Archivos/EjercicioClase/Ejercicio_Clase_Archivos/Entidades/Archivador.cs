using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Archivador
    {
        //StreamWriter streamWriter = new StreamWriter("ruta");


        public static void GuardarTexto(string path, bool append, string nombreArchivo, string texto)
        {
            //StreamWriter streamWriter = new StreamWriter("ruta",true, );
            if(path==null)
            {
                throw new Exception("Directorio inexistente");
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(path, append);
                streamWriter.Write(texto);
            }

        }

        public static string LeerTexto(string path, string texto)
        {            
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                return streamReader.ReadToEnd();
                
            }
            else
            {
                throw new Exception("No existe archivo");
            }
        }

    }    
}
