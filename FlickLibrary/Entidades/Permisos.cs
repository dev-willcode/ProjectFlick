using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Permisos
    {
        public Permisos()
        {
        }

        public int id { get; private set; }

        public string permiso_nombre { get; private set; }

        public string permiso_descripcion { get; private set; }
    }
}
