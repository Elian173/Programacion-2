//SQLConnection
//Nos permite conectarnos a la base de datos
using System;
using System.Data.SqlClient;
using Entidades;
using System.Collections.Generic;
//SQLCommand
//Nos permite controlar ponele no escuche bien jej


namespace BaseDeDatos
{
    public static class DAO //podria ser instanciada
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        static DAO()
        {
            DAO.connectionString = @"Server = .\SQLEXPRESS; Database= BDVet; Trusted_Connection = true;";

            string connectionString = @"Server = .\SQLEXPRESS; Database= BDVet; Trusted_Connection = true;";
            connection = new SqlConnection(connectionString);


            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text; //tiene 3 tipos

        }

        public static void InsertarCliente(string nombre, string apellido, string dni, DateTime? fechaNac)
        {
            try
            {
                connection.Open(); //Abro la connecion con la base de datos
                string comando = String.Format("INSERT INTO CLIENTES (nombre , apellido , dni) VALUES ('{0}' ,'{1}','{2}');", nombre, apellido, dni);
                //las comillas por afuera de la llave siempre el ; al final
                command.CommandText = comando;

                command.ExecuteNonQuery();//Ejecuta un comando
            }
            finally
            {
                if (connection != null &&
                    connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

        }


        //PARA MODIFICAR.

        public static void ModificarCliente(int id, string nombre, string apellido, string dni, DateTime? fechaNacimiento)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                //Creo un comando que se parsea despues
                string comando = "UPDATE CLIENTES SET nombre = @nombre ,apellido = @apellido , dni = @dni , fechaNacimiento =  @fechaNacimiento" +
                    " WHERE id = @id;";
                SqlCommand command = new SqlCommand(comando, connection);

                //reemplazo los valores temporales de la orden en el string 
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@id", id);

                //abro la conexion
                connection.Open();

                //ejecuto el comando.
                command.ExecuteNonQuery();
            }
        }

        //Para borrar
        public static void BorrarCliente(int id)
        {

            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "DELETE FROM CLIENTES WHERE id = @id;";
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        //LEER 
        public static List<Cliente> LeerClientes()
        {
            string comando = "SELECT id, nombre, apellido , dni, fechaNacimiento FROM CLIENTES;";
            SqlCommand command = new SqlCommand(comando, connection);
            connection.Open();
            //LEO
            SqlDataReader dataReader = command.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();

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

                Cliente c = new Cliente(id, nombre, apellido, dni,fechaNacimiento);
               
                //Cliente c = new Cliente(id, nombre, apellido, dni,DateTime.Now);
                clientes.Add(c);

            }

            return clientes;

        }

    }
}

//USAR EL USING Y USAR EL TRY FINALLY ES LO MISMO