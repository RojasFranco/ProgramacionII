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


    /*
    public ClaseUno(int n)
    {      

      try
      {
        ClaseUno clase = new ClaseUno();
      }
      catch(DivideByZeroException err)
      {
        Exception UnaExcepcion = new Exception("Err 2do ctor", err);
        throw UnaExcepcion;
        //throw new UnaException("Err 2do ctor", err);
      }        
    }*/


    public void MetodoInstancia()
    {


    }




  }
}
