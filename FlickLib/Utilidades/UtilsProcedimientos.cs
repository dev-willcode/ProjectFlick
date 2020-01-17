using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FlickLib.Utilidades
{
    class UtilsProcedimientos
    {
        public void agregarParametros(SqlCommand cmd, List<object> listaParametros, List<object> valores)
        {
            for (int i = 0; i < listaParametros.Count; i++)
            {
                cmd.Parameters.AddWithValue(listaParametros[i].ToString(), valores[i]);
            }
        }

        internal int evaluarInsercción(SqlCommand cmd)
        {
            // Cuando se afecte una fila, se habrá insertado correctamente.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return (int)reader["id"];
                }
                else
                {
                    return -1;
                }
            }
        }

        internal int contar(SqlCommand cmd)
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return (int)reader["count"];
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
