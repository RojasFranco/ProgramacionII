using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int precioHora;
            string nombre;
            int antiguedad;
            int cantidadHorasTrabajadas;
            int totalBruto;

            Console.Write("Precio por hora:");
            precioHora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Antiguedad: ");
            antiguedad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Horas trabajadas: ");
            cantidadHorasTrabajadas = Convert.ToInt32(Console.ReadLine());

            totalBruto = cantidadHorasTrabajadas * precioHora + antiguedad * 150;

            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Total bruto: {0}", totalBruto);
            Console.WriteLine("Descuento: {0}", totalBruto * 13 / 100);
            Console.WriteLine("Total neto: {0}", totalBruto * 87 / 100);

            Console.ReadKey();

        }
    }
}
