namespace DataAccess.Utilidades
{
    class UtilsConstantes
    {
        public const string cadenaConexion =
            "Server=tcp:developer-will.database.windows.net,1433;" +
            "Database=cinedb-master;Uid=dev.will;Pwd=admin123!;" +
            "Encrypt=yes;TrustServerCertificate=no;Connection Timeout=30;";

        public const string cadenaConexionLocal =
            "Data Source=.;Initial Catalog=cinedb;User ID=will;Password=admin123!";

    }
}
