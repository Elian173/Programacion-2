using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BaseDeDatos
{
    public static class DAOMascotas
    {
        private static SqlConnection connection;
        //private static SqlCommand command;
        private static string connectionString;

        static DAOMascotas()
        {
            DAOMascotas.connectionString = @"Server = .\SQLEXPRESS; Database= BDVet; Trusted_Connection = true;";
            DAOMascotas.connection = new SqlConnection(DAOMascotas.connectionString);
            //DAOMascotas.command = new SqlCommand();
            //DAOMascotas.command.Connection = DAOMascotas.connection;
           // DAOMascotas.command.CommandType = System.Data.CommandType.Text;

        }

        public static void InsertarMascota(string nombre,int idHumano)
        {
            using (SqlConnection connection = new SqlConnection(DAOMascotas.connectionString))
            {
                //Creo un comando que se parsea despues
                string comando = "INSERT INTO MASCOTAS (nombre , humano) VALUES (@nombre ,@idHumano)";
                SqlCommand command = new SqlCommand(comando, connection);

                //reemplazo los valores temporales de la orden en el string 
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@idHumano", idHumano);

                //abro la conexion
                connection.Open();

                //ejecuto el comando.
                command.ExecuteNonQuery();
            }

        }




    }
}
