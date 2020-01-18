using System;
using System.Data;

namespace FlickLib.Entidades.Vistas
{
    public class FuncionesActivas
    {
        public FuncionesActivas()
        {
        }
        public FuncionesActivas(IDataReader data)
        {
            id_pelicula = (int)data["id_pelicula"];
            pelicula_titulo = data["pelicula_titulo"].ToString();
            pelicula_titulo_original = data["pelicula_titulo_original"].ToString();
            pelicula_tipo_censura = data["pelicula_tipo_censura"].ToString();
            pelicula_duracion = data["pelicula_duracion"].ToString();
            pelicula_url_trailer = data["pelicula_url_trailer"].ToString();
            funcion_estado = data["funcion_estado"].ToString();
        }

        public int id_pelicula { get; private set; }

        public byte[] pelicula_imagen { get; private set; }

        public string pelicula_titulo { get; private set; }

        public string pelicula_titulo_original { get; private set; }

        public string pelicula_tipo_censura { get; private set; }

        public string pelicula_duracion { get; private set; }

        public string pelicula_url_trailer { get; private set; }

        public string funcion_estado { get; private set; }

        public string[] nombre_categoria { get; private set; }

        public string[] idioma_abreviatura { get; private set; }
    }
}
