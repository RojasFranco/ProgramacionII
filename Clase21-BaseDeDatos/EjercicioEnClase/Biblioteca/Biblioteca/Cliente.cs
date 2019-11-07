using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int id;
        private string dni;
        private DateTime? fechaNacimiento;
        private List<Mascota> mascotas;

        //public string 

        public Cliente(int id, string nombre, string apellido, string dni, DateTime? fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        
        public List<Mascota> Mascotas
        {
            get { return this.mascotas; }
            set { this.mascotas = value; }
        }

        public static implicit operator string(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} {1}", cliente.nombre, cliente.apellido));
            sb.AppendFormat("DNi: {0}\n", cliente.dni);
            if(cliente.fechaNacimiento != null)
            {
                sb.AppendFormat("FechaNacimiento: {0}\n", ((DateTime)cliente.fechaNacimiento));
            }

            sb.AppendLine("Las mascotas son:");


            return sb.ToString();
            
        }
    }
}
