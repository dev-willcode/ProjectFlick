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
            try
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
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió crear un Usuario", ex);
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarUsuario"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarEliminacion<Usuario>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar al usuario", ex);
            }
        }

        public override Usuario Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetUsuario"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Usuario>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener un usuario", ex);
            }
        }

        public override bool Update(Usuario Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarUsuario"))
                {
                    Procedimientos.agregarParametros(cmd,
                      new List<object>() {
                        "@id",
                        "@usuario_username",
                        "@usuario_password",
                        "@usuario_perfil" },
                        new List<object>() {
                        Entidad.id,
                        Entidad.usuario_username,
                        Entidad.usuario_password,
                        Entidad.usuario_perfil}
                        );

                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió actualizar el usuario", ex);
            }
        }
    }
}
