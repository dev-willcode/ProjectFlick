namespace Entity.Entidades
{
    public class Pelicula_Categoria : Entidad
    {
        public Pelicula_Categoria()
        {
        }

        public int id_Pelicula { get; private set; }

        public int id_Categoria { get; private set; }
    }
}
