using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorPedido;
            int minimo = default(int); // En lugar de 0;
            int maximo=default(int);
            int cantidadNumeros = 0;
            int sumaTotal=0;
            float promedio;

            while (cantidadNumeros<2)
            {

                Console.Write("Ingrese numero:");                
                if(int.TryParse(Console.ReadLine(), out valorPedido))
                {

                    if(Validacion.Validar(valorPedido, -100, 100))
                    {
                        sumaTotal += valorPedido;
                        if (cantidadNumeros == 0)
                        {
                            minimo = valorPedido;
                            maximo = valorPedido;                                                        
                        }
                        else
                        {
                            if(valorPedido<minimo)
                            {
                                minimo = valorPedido;
                            }
                            if(valorPedido>maximo)
                            {
                                maximo = valorPedido;
                            }
                        }
                        cantidadNumeros += 1;
                    }
                    else
                    {
                        Console.WriteLine("El nro no se encuentra en el rango");
                    }
                }                
            }
            promedio = (float)sumaTotal / cantidadNumeros;
            Console.WriteLine("minimo: {0} - maximo: {1} - promedio: {2}", minimo, maximo, promedio);
            Console.ReadKey();
        }
    }
}
