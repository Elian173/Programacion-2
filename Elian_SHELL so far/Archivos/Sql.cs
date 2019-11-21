using System;
using System.Collections.Generic;
//using
using System.Data.SqlClient;

namespace Archivos
{
    public class Sql: IArchivo<Queue<Object>>
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString;   // capas no se usa nose

        public Sql()
        {
            //connectionString = "Algo";//@"Server = .\SQLEXPRESS; Database= BDVet; Trusted_Connection = true;";
            this.connectionString = "Algo";//@"Server = .\SQLEXPRESS; Database= BDVet; Trusted_Connection = true;";

            this.connection = new SqlConnection(this.connectionString);

            this.command = new SqlCommand();
            this.command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text; //tiene 3 tipos
        }

        public void Guardar( string tabla, Queue<Object> datos )
        {
            Insert(tabla, datos);
        }

        public void Leer( string archivo, out Queue<Object> datos )
        {
            throw new NotImplementedException();
        }

        public void Insert( string tabla, Queue<Object> datos )
        {
            using (SqlConnection connection = new SqlConnection(tabla)) //this.connectionString
            {
                //Creo un comando que se parsea despues
                string comando = "INSERT INTO ALGO (parametroUNO , parametroDOS) VALUES (@parametroUNO ,@parametroDOS)";
                //string comando = String.Format("INSERT INTO CLIENTES (nombre , apellido , dni) VALUES ('{0}' ,'{1}','{2}');", nombre, apellido, dni);
                SqlCommand command = new SqlCommand(comando, connection);

                //reemplazo los valores temporales de la orden en el string

                foreach (Object x in datos)
                {
                    //command.Parameters.AddWithValue("@parametroUno", parametroUNO);
                    // command.Parameters.AddWithValue("@idHumano", parametroDOS);
                }

                //abro la conexion
                connection.Open();

                //ejecuto el comando.
                command.ExecuteNonQuery();
            }
        }

        public void Modify( int id, Object mod, string tabla )

        {
            using (SqlConnection connection = new SqlConnection(tabla)) //this.connectionString
            {
                //Creo un comando que se parsea despues
                string comando = "UPDATE ALGO SET parametroUNO = @parametroUNO ,parametroDOS = @parametroDOS WHERE id = @id;";
                SqlCommand command = new SqlCommand(comando, connection);

                //reemplazo los valores temporales de la orden en el string
                //command.Parameters.AddWithValue("@parametroUNO", parametroUNO);
                //command.Parameters.AddWithValue("@parametroDos", parametroDos);
                command.Parameters.AddWithValue("@id", id);

                //abro la conexion
                connection.Open();

                //ejecuto el comando.
                command.ExecuteNonQuery();
            }
        }

        public void Delete( int id, string tabla )
        {
            using (SqlConnection connection = new SqlConnection(tabla)) //this.connectionString
            {
                string comando = "DELETE FROM CLIENTES WHERE id = @id;";
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Queue<Object> Read( string tabla )
        {
            string comando = "SELECT id, nombre, apellido , dni, fechaNacimiento FROM CLIENTES;";
            Queue<Object> objetos = new Queue<object>();

            using (SqlConnection connection = new SqlConnection(tabla)) // this.connectionstring
            {
                SqlCommand command = new SqlCommand(comando, connection);
                //LEO
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    string dni = dataReader.GetString(3);
                    /*
                    DateTime? fechaNacimiento = null;

                    if (!dataReader.IsDBNull(4))
                    {
                        fechaNacimiento = dataReader.GetDateTime(4);
                    }
                    */

                    //Cliente c = new Cliente(id, nombre, apellido, dni, fechaNacimiento);      voy creando el obj que necesito

                    //objetos.Enqueue(c);   // Añado el obj a la cola
                }

                return objetos;
            }
        }
    }
}