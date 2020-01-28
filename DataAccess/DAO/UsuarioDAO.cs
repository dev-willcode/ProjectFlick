using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Utilidades;
using Entity.Entidades;

namespace DataAccess.DAO
{
    public class UsuarioDAO : IDataAccess<Usuario>
    {
        UtilsProcedimientos proced = new UtilsProcedimientos();
        public int Create(Usuario Entidad)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CrearUsuario";

                proced.agregarParametros(cmd,
                    new List<object>() {
                        "@usuario_username",
                        "@usuario_password",
                        "@usuario_perfil" },
                    new List<object>() {
                        Entidad.usuario_username,
                        Entidad.usuario_password,
                    Entidad.usuario_perfil == 0 ? DBNull.Value : (object)Entidad.usuario_perfil }
                    );

                return proced.evaluarInsercción(cmd);
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente inicioSesion(Usuario Entidad)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_IniciarSesion";

                proced.agregarParametros(cmd,
                    new List<object>() {
                        "@usuario_username",
                        "@usuario_password",
                        },
                    new List<object>() {
                        Entidad.usuario_username,
                        Entidad.usuario_password,
                    }
                    );
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Cliente(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario Entidad)
        {
            throw new NotImplementedException();
        }

        public int ContarRepetidos(string usuario_username)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) AS 'count' FROM [Usuario] usuario " +
                    "WHERE usuario.usuario_username = '" + usuario_username + "'";
                return proced.contar(cmd);
            }
        }
    }
}
