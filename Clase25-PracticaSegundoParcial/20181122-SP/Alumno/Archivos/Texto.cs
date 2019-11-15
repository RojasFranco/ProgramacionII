using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                writer.Write(datos);
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            using (StreamReader reader = new StreamReader(archivo))
            {
                datos = new Queue<Patente>();
                /*string lineasTotales = reader.ReadToEnd();
                string[] leerDeAca = lineasTotales.Split('\n');
                                foreach(string linea in leerDeAca)
                {
                    try
                    {
                        datos.Enqueue(linea.ValidarPatente());
                    }                    
                    catch(PatenteInvalidaException err)
                    {
                        throw err;
                    }

                }    
                */
                while (!reader.EndOfStream)
                {
                    string patenteEvaluar = reader.ReadLine();                    
                    try
                    {
                        datos.Enqueue(patenteEvaluar.ValidarPatente());
                    }
                    catch (PatenteInvalidaException err)
                    {
                        throw err;
                    }
                }
                            
                // VER


            }
        }
    }
}
