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

        public SqlCommand CrearComandoSP(string procedimientoAlmacenado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimientoAlmacenado;
                cmd.Connection = Configuraciones.connect;
                return cmd;
            }
            catch (Exception ex)
            {

                throw ex;
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

        public SqlCommand CrearComandoQ(string comando)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comando;
            cmd.Connection = Configuraciones.connect;
            return cmd;
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
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                Entidad entidad = null;
                if (reader.Read())
                {
                    entidad = Activator.CreateInstance(typeof(T), reader) as Entidad;
                }
                return (T)entidad;
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
    }
}
