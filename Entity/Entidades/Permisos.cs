﻿namespace Entity.Entidades
{
    public class Permisos : Entidad
    {
        public Permisos()
        {
        }

        public int id { get; private set; }

        public string permiso_nombre { get; private set; }

        public string permiso_descripcion { get; private set; }
    }
}
