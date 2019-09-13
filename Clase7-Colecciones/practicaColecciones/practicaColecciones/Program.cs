using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             Crear lista, cargarla con 5 nros aleatorios.
             Recorrer y mostrar en una misma linea los nros en la lista.
             Ordenarlos de forma descendente.
             Recorrer y mostrar el contenido de la lista ordenada en una misma linea             
             * 
             * */

            Random random = new Random();            
            List<int> lista;
            lista = new List<int>();
            
            for(int i=0; i<5; i++)
            {
                lista.Add(random.Next(1, 100));
            }

            for(int j=0;j<5; j++)
            {
                Console.Write(" {0} ",lista[j]);                
            }


            lista.Sort(Comparar);            
            Console.Write("\n");
            foreach(int numero in lista)
            {
                Console.Write(" {0} ", numero);
            }            
            

            Console.ReadKey();
        }


        private static int Comparar(int x, int y)
        {
            if(x<y)
            {
                return 1;
            }
            else if(x==y)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
