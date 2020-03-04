using System.Data;

namespace Entity.Entidades
{
    public class Categoria : Entidad
    {
        public Categoria()
        {
        }

        public Categoria(IDataReader data)
        {
            id = (int)data["id"];
            categoria_nombre = data["categoria_nombre"].ToString();
        }

        public int id { get;  set; }

        public string categoria_nombre { get;  set; }
    }
}
