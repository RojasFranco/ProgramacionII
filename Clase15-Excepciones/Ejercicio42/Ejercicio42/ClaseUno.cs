using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
  public class ClaseUno
  {

    //Metodo estatico lanza primer Excepcion
    public static void MetodoEstatico()
    {
      throw new DivideByZeroException();
    }


    public ClaseUno()
    {
      try
      {
        ClaseUno.MetodoEstatico();
      }
      catch(DivideByZeroException error)
      {        
        throw new UnaException("Err 2do ctor", error);
      }
    }


    
    public ClaseUno(int n)
    {      

      try
      {
        ClaseUno clase = new ClaseUno();
      }
      catch(UnaException err) //Tiene unaException y el division por inner
      {
        throw err;
        //throw new ClaseUno(3); UnaException("Err 2do ctor", err);
      }        
    }

    public static void MetodoInstancia()
    {
        try
        {
            new ClaseUno(3);
        }        
        catch(UnaException error)
        {
            throw new MiException("Ult error", error);
        }
    }
  }
}
