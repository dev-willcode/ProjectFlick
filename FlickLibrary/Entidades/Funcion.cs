﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Funcion
    {
        public Funcion()
        {
        }

        public int id { get; private set; }

        public int funcion_pelicula { get; private set; }

        public int funcion_sala { get; private set; }

        public DateTime funcion_fecha_evento { get; private set; }

        public int funcion_horario { get; private set; }

        public string funcion_estado { get; private set; }

        public double funcion_precio_boleto { get; private set; }

        public DateTime funcion_fecha_creacion { get; private set; }
    }
}
