using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        static DAO()
        {
            //Este string connectionString lo puedo usar asi o como lo hice abajo con un string statico como atributo de clase
            //string connectionString = @"Server =  .\SQLEXPRESS; DataBase = BDVet; Trusted_Connection = true;"; //@para no poner '//' y saltear ESTE USE PARA INSERTAR


            DAO.connectionString = @"Server =  .\SQLEXPRESS; DataBase = BDVet; Trusted_Connection = true;"; //Uso esto para otra forma de hacerlo(lo uso en modificar)
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text; //Text para ejecutar - Storprocedure es para otros casos


        }

        public static void InsertarCliente(string nombre, string apellido, string dni, DateTime fechaNacimiento)
        {
            try
            {
                connection.Open();
                string comando = string.Format("INSERT INTO CLIENTES (Nombre, apellido, dni) " + "VALUES ('{0}', '{1}', '{2}');", nombre, apellido, dni);
                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            /*catch (Exception)
            {

                throw;
            }*/
            finally
            {
                if(connection!=null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void ModificarCliente(int id, string nombre, string apellido, string dni, DateTime? fechaNacimiento)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))//Con esto no haria falta declarar command en el constructor
            {
                string comando = "UPDATE CLIENTES SET nombre = @nombre, " +
                    "apellido = @apellido, dni = @dni, fecha_nacimiento = @fechaNacimiento" +
                    " WHERE id = @id;"; //command va a reemplazar las @

                //command.CommandText = comando; Este no usamos                
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@nombre", nombre); //Propiedad de SqlCommand PARA INSERTAR DE FORMA SEGURA!
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery(); //Aca recien se ejecuta
            }

        }

        
        public static void InsertarMascota(string nombre, int idHumano)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "INSERT INTO MASCOTAS (nombre, idHumano) VALUES (@nombre, @idHumano);";
                SqlCommand command = new SqlCommand(comando, connection);
                
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@idHumano", idHumano);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        

        public static List<Cliente> LeerClientes()
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))//Con esto no haria falta declarar command en el constructor
            {
                string comando = "SELECT id, nombre, apellido, dni, fecha_nacimiento FROM CLIENTES;";

                SqlCommand command = new SqlCommand(comando, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader(); //EJECUTA EL COMANDO
                List<Cliente> retorno = new List<Cliente>();

                while(dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    string dni = dataReader.GetString(3);

                    DateTime? fechaNacimiento = null;
                    if (!dataReader.IsDBNull(4))
                    {
                        fechaNacimiento = dataReader.GetDateTime(4);
                    }                   
                    //LE PASO CADA POSICION PARA LEER

                    Cliente cliente = new Cliente(id, nombre, apellido, dni, fechaNacimiento);
                    retorno.Add(cliente);
                }
                //ACA NO SE USA EXECUTENONQUERY
                return retorno;
            }
        }
    }
}
