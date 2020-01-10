using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Pelicula_Categoria
    {
        public Pelicula_Categoria()
        {
        }

        public int id_Pelicula { get; private set; }

        public int id_Categoria { get; private set; }
    }
}
