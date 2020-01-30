using System;
using System.Data.SqlClient;

namespace Controllers.Utilidades
{
    public class Configuraciones
    {
        public static SqlConnection connect = crearConexion(UtilsConstantes.cadenaConexionLocal);

        private static SqlConnection crearConexion(string cadenaConexion)
        {
            try
            {
                SqlConnection Connection = new SqlConnection(cadenaConexion);
                Connection.Open();
                Console.WriteLine("Conectado correctamente");
                return Connection;
            }
            catch (Exception)
            {
                Console.WriteLine("No se logró conectar");
                return null;
            }
        }
    }
}
