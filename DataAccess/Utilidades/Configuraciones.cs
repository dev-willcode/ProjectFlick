using System;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Utilidades;

namespace Controllers.Utilidades
{
    public class Configuraciones
    {
        public const string cadenaConexion =
            "Server=tcp:dev-willcode.database.windows.net,1433;" +
            "Database=cinedb;Uid=will;Pwd=admin123!;" +
            "Encrypt=no;TrustServerCertificate=no;";

        public const string cadenaConexionLocal =
            "Data Source=.;Initial Catalog=cinedb;User ID=will;Password=admin123!";

        public SqlConnection connect;

        public void CrearConexion()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(cadenaConexion);
                Connection.Open();
                Console.WriteLine("Conectado correctamente: Conexión exitosa:" + DateTime.Now.ToString());
                connect = Connection;
            }
            catch (Exception ex)
            {
                throw new ConexionException("Error al conectarse a la base de datos.", ex);
            }
        }

        public void Cerrarconexion()
        {
            if (connect.State.Equals(ConnectionState.Open))
            {
                connect.Close();
            }
        }
    }
}
