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

        public int id { get; set; }

        public string pelicula_titulo { get; set; }

        public string pelicula_titulo_original { get; set; }

        public string pelicula_duracion { get; set; }

        public string pelicula_tipo_censura { get; set; }

        public string pelicula_sinopsis { get; set; }

        public string pelicula_director { get; set; }

        public string pelicula_reparto { get; set; }

        public string pelicula_url_trailer { get; set; }

        public byte[] pelicula_imagen { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Pelicula pelicula = obj as Pelicula;
            return pelicula_titulo == pelicula.pelicula_titulo &&
                pelicula_titulo_original == pelicula.pelicula_titulo_original &&
                pelicula_duracion == pelicula.pelicula_duracion &&
                pelicula_tipo_censura == pelicula.pelicula_tipo_censura &&
                pelicula_sinopsis == pelicula.pelicula_sinopsis &&
                pelicula_director == pelicula.pelicula_director &&
                pelicula_reparto == pelicula.pelicula_reparto &&
                pelicula_url_trailer == pelicula.pelicula_url_trailer &&
                pelicula_imagen == pelicula.pelicula_imagen;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
