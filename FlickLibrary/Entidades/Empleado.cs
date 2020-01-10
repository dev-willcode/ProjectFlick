using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Empleado
    {

        public Empleado()
        {
        }

        public int id { get; private set; }

        public string empleado_nombres { get; private set; }

        public string empleado_apellidos { get; private set; }

        public string empleado_telefono { get; private set; }

        public string empleado_email { get; private set; }

        public string empleado_direccion { get; private set; }

        public int empleado_usuario { get; private set; }
    }
}
