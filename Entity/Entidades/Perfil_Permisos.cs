using System.Data;

namespace Entity.Entidades
{
    public class Perfil_Permisos : Entidad
    {
        public Perfil_Permisos()
        {
        }

        public Perfil_Permisos(IDataReader data)
        {
            id_Perfil = (int)data["id_perfil"];
            id_Permiso = (int)data["id_permiso"];
        }

        public int id_Perfil { get; private set; }

        public int id_Permiso { get; private set; }
    }
}
