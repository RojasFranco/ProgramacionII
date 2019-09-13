using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             Crear una lista, una cola y una pila .
             Cargar la lista con 5 nros aleatorios.
             Recorrer y mostrar en una misma linea los nros en la lista.
             Al mismo tiempo cargar los nros en la pila.
             Recorrer la pila, mostrar en una misma linea el contenido y 
             al mismo tiempo cargar cada elemento devuelto en la cola.
             Recorrer la cola, mostrar en una misma linea el contenido             
             * 
             */

            List<int> lista = new List<int>();
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();

            Random random = new Random();            

            for(int i=0; i<5; i++)
            {
                int numeroRandom = random.Next(1, 100);
                lista.Add(numeroRandom);
                Console.Write(" {0} ", numeroRandom);
                pila.Push(numeroRandom);
            }

            Console.Write("\n");
            for (int j = 0; j < 5; j++)
            {
                int numeroMostrar;
                numeroMostrar = pila.Pop();
                cola.Enqueue(numeroMostrar);

                Console.Write(" {0} ", numeroMostrar);
            }

            Console.WriteLine();
            for (int k=0; k<5; k++)
            {
                int numeroMostrar;
                numeroMostrar = cola.Dequeue();
                Console.Write(" {0} ", numeroMostrar);
            }

            Console.ReadKey();
        }
    }
}
