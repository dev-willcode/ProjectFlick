using System.Data;

namespace Entity.Entidades
{
    public class Perfil_Usuario : Entidad
    {
        public Perfil_Usuario()
        {
        }

        public Perfil_Usuario(IDataReader data)
        {
            id = (int)data["id"];
            perfil_usuario_nombre = data["perfil_usuario_nombre"].ToString();
        }

        public int id { get; private set; }

        public string perfil_usuario_nombre { get; private set; }
    }
}
