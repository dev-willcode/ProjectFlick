namespace Controllers.Utilidades
{
    class UtilsConstantes
    {
        public const string cadenaConexion =
            "Server=tcp:dev-willcode.database.windows.net,1433;" +
            "Database=cinedb;Uid=will;Pwd=admin123!;" +
            "Encrypt=yes;TrustServerCertificate=no;Connection Timeout=10;";

        public const string cadenaConexionLocal =
            "Data Source=.;Initial Catalog=cinedb;User ID=will;Password=admin123!";

    }
}
