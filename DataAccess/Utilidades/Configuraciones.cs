using System;
using System.Data.SqlClient;

namespace Controllers.Utilidades
{
    public class Configuraciones
    {
        public static SqlConnection connect = crearConexion();

        private static SqlConnection crearConexion()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(UtilsConstantes.cadenaConexion);
                Connection.Open();
                Console.WriteLine("Conectado correctamente");
                return Connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se logró conectar");
                throw ex;
            }
        }

        public static void cerrarconexion()
        {
            connect.Close();
        }
    }
}
