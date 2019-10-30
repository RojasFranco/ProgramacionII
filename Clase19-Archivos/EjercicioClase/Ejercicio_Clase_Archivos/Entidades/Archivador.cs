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
            if(!Directory.Exists(path))
            {
                throw new Exception("Directorio inexistente");
            }
            else
            {
                string nombreCompleto = path + "\\" + nombreArchivo + ".txt";
                StreamWriter streamWriter = new StreamWriter(nombreCompleto, append);
                
                streamWriter.WriteLine(texto);
                streamWriter.Close();
                //nombreArchivo += ".txt";
            }

        }

        public static string LeerTexto(string path)
        {            
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string retorno = streamReader.ReadToEnd();
                streamReader.Close();
                return retorno;
                
            }
            else
            {
                throw new Exception("No existe archivo");
            }
        }

    }    
}
