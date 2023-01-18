using System;
using System.Data.SqlClient;
using DataAccess.Utilidades;

namespace Controllers.Utilidades
{
    public class Configuraciones
    {
        public const string cadenaConexion =
            "Server=34.74.3.129;Database=cinedb;Uid=sqlserver;Pwd=admin123!;";

        public const string cadenaConexionLocal =
            "Data Source=.;Initial Catalog=cinedb;User ID=will;Password=admin123!";

        public static SqlConnection CrearConexion()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(cadenaConexionLocal);
                Connection.Open();
                Console.WriteLine("Conectado correctamente: Conexión exitosa:" + DateTime.Now.ToString());
                return Connection;
            }
            catch (Exception ex)
            {
                throw new ConexionException("Error al conectarse a la base de datos.", ex);
            }
        }
    }
}
