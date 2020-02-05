using System.Data;

namespace Entity.Entidades
{
    public class Permisos : Entidad
    {
        public Permisos()
        {
        }

        public Permisos(IDataReader data)
        {
            id = (int)data["id"];
            permiso_nombre = data["permiso_nombre"].ToString();
            permiso_descripcion = data["permiso_descripcion"].ToString();
        }

        public int id { get; private set; }

        public string permiso_nombre { get; private set; }

        public string permiso_descripcion { get; private set; }
    }
}
