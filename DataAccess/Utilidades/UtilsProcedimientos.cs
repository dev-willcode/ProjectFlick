using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.Utilidades
{
    public class UtilsProcedimientos
    {
        public void agregarParametros(SqlCommand cmd, List<object> listaParametros, List<object> valores)
        {
            for (int i = 0; i < listaParametros.Count; i++)
            {
                cmd.Parameters.AddWithValue(listaParametros[i].ToString(), valores[i]);
            }
        }

        public int contar(SqlCommand cmd)
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

        public int evaluarInsercción(SqlCommand cmd)
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

        public bool evaluarActualizacion(SqlCommand cmd)
        {
            // Cuando se actualiza un registro, se habrá actualizaod ocn éxito.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return (reader["RESPONSE"].ToString().Equals("CORRECTO"));
                }
                return false;
            }
        }
    }
}
