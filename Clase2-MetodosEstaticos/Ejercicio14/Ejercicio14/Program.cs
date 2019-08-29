using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double basee;
            double altura;
            double radio;
            int opcion;

            do
            {
                Console.WriteLine("1-Area Cuadrado 2- Area Triangulo 3- Area circulo - 4- Salir");
                Console.Write("Opcion a realizar:");
                if(!int.TryParse(Console.ReadLine(), out opcion) || opcion>4)
                {
                    Console.WriteLine("Opcion invalida, vuelva a ingresar:");
                }
                if(opcion==1)
                {
                    Console.WriteLine("Ingrese base de cuadrado:");
                    while (!double.TryParse(Console.ReadLine(), out basee))
                    {
                        Console.WriteLine("Dato invalido, vuelva a ingresar:");
                    }
                    Console.WriteLine("Area: {0}", CalculoDeArea.CalcularCuadrado(basee));
                }
                if(opcion==2)
                {
                    Console.WriteLine("Ingrese base de triangulo:");
                    while (!double.TryParse(Console.ReadLine(), out basee))
                    {
                        Console.WriteLine("Dato invalido, vuelva a ingresar:");
                    }
                    Console.WriteLine("Ingrese altura de triangulo:");
                    while (!double.TryParse(Console.ReadLine(), out altura))
                    {
                        Console.WriteLine("Dato invalido, vuelva a ingresar:");
                    }
                    Console.WriteLine("Area: {0}", CalculoDeArea.CalcularTriangulo(altura, basee));
                }
                if(opcion==3)
                {
                    Console.WriteLine("Ingrese radio de circulo:");
                    while (!double.TryParse(Console.ReadLine(), out radio))
                    {
                        Console.WriteLine("Dato invalido, vuelva a ingresar:");
                    }                    
                    Console.Write("Area: {0}", CalculoDeArea.CalcularCirculo(radio));
                }                    

            }while(opcion!=4);
            Console.ReadKey();
        }                
    }
}
