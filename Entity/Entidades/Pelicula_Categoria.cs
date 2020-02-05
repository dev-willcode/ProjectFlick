using System.Data;

namespace Entity.Entidades
{
    public class Pelicula_Categoria : Entidad
    {
        public Pelicula_Categoria()
        {
        }

        public Pelicula_Categoria(IDataReader data)
        {
            id_Pelicula = (int)data["id_Pelicula"];
            id_Categoria = (int)data["id_Categoria"];
        }
        public int id_Pelicula { get; private set; }

        public int id_Categoria { get; private set; }
    }
}
