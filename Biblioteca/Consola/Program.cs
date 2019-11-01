using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DAO.InsertarCliente("Mauricio", "Cerizza", "21321312", DateTime.Now);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
