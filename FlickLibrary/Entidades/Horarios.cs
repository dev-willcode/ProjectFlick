using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Horarios
    {
        public Horarios()
        {
        }

        public int id { get; private set; }

        public string horario_valor { get; private set; }

        public DateTime horario_inicio { get; private set; }

        public DateTime horario_fin { get; private set; }
    }
}
