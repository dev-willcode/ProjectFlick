using System;
using System.Data;

namespace Entity.Entidades
{
    public class Usuario : Entidad
    {
        public Usuario()
        {
        }

        public Usuario(IDataReader data)
        {
            id = (int)data["id"];
            usuario_username = data["usuario_username"].ToString();
            usuario_password = data["usuario_password"].ToString();
            usuario_perfil = data["usuario_perfil"].GetType().Equals(typeof(DBNull)) ?
               0 : (int)data["usuario_perfil"];
  
        }

        public int id { get; set; }

        public string usuario_username { get; set; }

        public string usuario_password { get; set; }

        public int usuario_perfil { get; set; }
    }
}
