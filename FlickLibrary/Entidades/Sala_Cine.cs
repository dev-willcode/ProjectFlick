namespace FlickLibrary.Entidades
{
    public class Sala_Cine
    {
        public Sala_Cine()
        {
        }

        public int id { get; private set; }

        public string sala_nombre { get; private set; }

        public int sala_capacidad_maxima { get; private set; }
    }
}
