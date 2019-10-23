using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
  class Program
  {
    static void Main(string[] args)
    {

      /*try
      {
        ClaseUno clase = new ClaseUno();
        clase.MetodoInstancia();

      }
      catch(DivideByZeroException error)
      {
        Console.WriteLine(error.Message);        
      }*/



      /*
      catch(MiException errorMiException)
      {
        Console.WriteLine(errorMiException.Message);
        Console.WriteLine(errorMiException.InnerException.Message);
      }*/
      try
      {
        ClaseUno.MetodoInstancia();
      }
      catch(MiException miError)
      {
        Exception exceptionGeneral = miError;
        while(exceptionGeneral != null)
        {
            Console.WriteLine(exceptionGeneral.Message);
            exceptionGeneral = exceptionGeneral.InnerException;
        }
      }


      
      Console.ReadKey();
    }
  }
}
