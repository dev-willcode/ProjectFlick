using System;
using System.Data;

namespace Entity.Entidades
{
    public class Sala_Cine : Entidad
    {
        public Sala_Cine()
        {
        }

        public Sala_Cine(IDataReader data)
        {
            id = (int)data["id"];
            sala_nombre = data["sala_nombre"].ToString();
            sala_capacidad_maxima = (int)data["sala_capacidad_maxima"];
        }

        public int id { get; private set; }

        public string sala_nombre { get; private set; }

        public int sala_capacidad_maxima { get; private set; }
    }
}
