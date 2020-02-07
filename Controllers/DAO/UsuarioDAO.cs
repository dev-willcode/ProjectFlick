using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class UsuarioDAO : IDataAccess<Usuario>
    {
        public override int Create(Usuario Entidad)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearUsuario"))
            {
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

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Usuario Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
