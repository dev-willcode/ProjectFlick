using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Pelicula
    {
        public Pelicula()
        {
        }

        public int id { get; private set; }

        public string pelicula_titulo { get; private set; }

        public string pelicula_titulo_original { get; private set; }

        public string pelicula_idioma { get; private set; }

        public string pelicula_duracion { get; private set; }

        public string pelicula_tipo_censura { get; private set; }

        public string pelicula_sinopsis { get; private set; }

        public string pelicula_director { get; private set; }

        public string pelicula_reparto { get; private set; }

        public string pelicula_url_trailer { get; private set; }

        public byte[] pelicula_imagen { get; private set; }
    }
}
