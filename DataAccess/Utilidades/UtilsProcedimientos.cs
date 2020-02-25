using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entity.Entidades;

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

        public SqlCommand CrearComandoSP(string procedimientoAlmacenado)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = procedimientoAlmacenado,
                Connection = Configuraciones.CrearConexion()
            };
            return cmd;
        }


        public SqlCommand CrearComandoQ(string comando)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = comando,
                Connection = Configuraciones.CrearConexion()
            };
            return cmd;
        }
        public string obtenerString(SqlCommand cmd)
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader[0] as string;
                }
                else
                {
                    throw new DataException("Error al devolver la cadena");
                }
            }
        }

        public Entidad DevolverEntidad<T>(SqlCommand cmd)
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return Activator.CreateInstance(typeof(T), reader) as Entidad;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<T> ListarEntidades<T>(SqlCommand cmd)
        {
            Entidad entidad;
            ArrayList listado = new ArrayList();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    entidad = Activator.CreateInstance(typeof(T), reader) as Entidad;
                    listado.Add(entidad);
                }
            }
            return listado.Cast<T>().ToList();
        }

        public int retornarConteo(SqlCommand cmd)
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

        public T evaluarObtención<T>(SqlCommand cmd)
        {
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Entidad entidad = null;
                    if (reader.Read())
                    {
                        entidad = Activator.CreateInstance(typeof(T), reader) as Entidad;
                        return (T)entidad;
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
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

        public bool evaluarEliminacion<T>(SqlCommand cmd)
        {
            // Cuando retorna "ELIMINADO", se habrá eliminado con éxito.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return (reader["RESPONSE"].ToString().Equals("ELIMINADO"));
                }
                return false;
            }
        }
    }
}
