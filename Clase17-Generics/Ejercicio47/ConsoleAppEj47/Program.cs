using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace ConsoleAppEj47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Clausura");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            EquipoFutbol equipo1= new EquipoFutbol("River", DateTime.Parse("25/05/93"));
            EquipoFutbol equipo2 = new EquipoFutbol("Bocaca", DateTime.Parse("20/02/95"));
            EquipoFutbol equipo3 = new EquipoFutbol("Independiente", DateTime.Parse("08/08/98"));

            EquipoBasquet equipo4 = new EquipoBasquet("San antonio", DateTime.Parse("02/02/92"));
            EquipoBasquet equipo5 = new EquipoBasquet("Spurs", DateTime.Parse("01/01/01"));
            EquipoBasquet equipo6 = new EquipoBasquet("nose", DateTime.Parse("11/11/2011"));

            torneoFutbol += equipo1;
            torneoFutbol += equipo2;
            torneoFutbol += equipo3;

            torneoBasquet += equipo4;
            torneoBasquet += equipo5;
            torneoBasquet += equipo6;            

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine("***************\n");
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine("****************\n");


            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);


            Console.ReadKey();
        }
    }
}
