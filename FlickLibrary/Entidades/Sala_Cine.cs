using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Sala_Cine
    {
        public Sala_Cine()
        {
        }

        public int id { get; private set; }

        public string sala_nombre { get; private set; }

        public int sala_capacidad_maxima { get; private set; }
    }
}
