using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio56
{
    public static class Archivador
    {

        public static string LeerArchivo(string ruta)
        {
            if(File.Exists(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }                    
            }
            else
            {
                throw new FileNotFoundException();
            }

        }

        public static void GuardarArchivo(string ruta, bool append, string textoAGuardar)
        {
         /*   if(Directory.Exists(ruta))
            {*/
                string rutaCompleta = ruta;
                using (StreamWriter streamWriter = new StreamWriter(rutaCompleta, append))
                {
                    string[] textoConSaltoLineaGuardar = textoAGuardar.Split('\n');

                    foreach (string palabra in textoConSaltoLineaGuardar)
                    {
                        streamWriter.WriteLine(palabra);
                    }
                }                                
            /*}
            else
            {
                throw new DirectoryNotFoundException();
            }*/
        }

    }
}
