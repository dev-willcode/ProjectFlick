using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Controllers.Controller;
using Controllers.Utilidades;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class UsuarioDAO : IController, IDataAccess<Usuario>
    {
        public int Create(Usuario Entidad)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CrearUsuario";

                Procedimientos.agregarParametros(cmd,
                    new List<object>() {
                        "@usuario_username",
                        "@usuario_password",
                        "@usuario_perfil" },
                    new List<object>() {
                        Entidad.usuario_username,
                        Entidad.usuario_password,
                    Entidad.usuario_perfil == 0 ? DBNull.Value : (object)Entidad.usuario_perfil }
                    );

                return Procedimientos.evaluarInsercción(cmd);
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
