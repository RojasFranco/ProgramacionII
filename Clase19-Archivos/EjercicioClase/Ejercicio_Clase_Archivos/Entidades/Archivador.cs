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

                string[] archEscribir = texto.Split('\n');//Esto agrego para guardar con salto de linea

                StreamWriter streamWriter = new StreamWriter(nombreCompleto, append);
                
                //streamWriter.WriteLine(texto); Esto funciona
                
                foreach(string palabra in archEscribir)
                {
                    streamWriter.WriteLine(palabra);
                }
                streamWriter.Close();                
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
