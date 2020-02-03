using System;
using System.Data;

namespace Entity.Entidades
{
    public class Pelicula : Entidad
    {
        public Pelicula()
        {
        }

        public Pelicula(IDataReader data)
        {
            id = (int)data["id"];
            pelicula_titulo = data["pelicula_titulo"].ToString();
            pelicula_titulo_original = data["pelicula_titulo_original"].ToString();
            pelicula_duracion = data["pelicula_duracion"].ToString();
            pelicula_tipo_censura = data["pelicula_tipo_censura"].ToString();
            pelicula_sinopsis = data["pelicula_sinopsis"].ToString();
            pelicula_director = data["pelicula_director"].ToString();
            pelicula_reparto = data["pelicula_reparto"].ToString();
            pelicula_url_trailer = data["pelicula_url_trailer"].ToString();
            pelicula_imagen = data["pelicula_imagen"].GetType().Equals(typeof(DBNull)) ? 
                null : (byte[])data["pelicula_imagen"];
        }

        public int id { get; private set; }

        public string pelicula_titulo { get; private set; }

        public string pelicula_titulo_original { get; private set; }

        public string pelicula_duracion { get; private set; }

        public string pelicula_tipo_censura { get; private set; }

        public string pelicula_sinopsis { get; private set; }

        public string pelicula_director { get; private set; }

        public string pelicula_reparto { get; private set; }

        public string pelicula_url_trailer { get; private set; }

        public byte[] pelicula_imagen { get; private set; }
    }
}
