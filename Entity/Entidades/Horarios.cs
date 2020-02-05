using System;
using System.Data;

namespace Entity.Entidades
{
    public class Horarios : Entidad
    {
        public Horarios()
        {
        }

        public Horarios(IDataReader data)
        {
            id = (int)data["id"];
            horario_inicio = (TimeSpan)data["horario_inicio"];
            horario_fin = (TimeSpan)data["horario_fin"];
        }

        public int id { get; private set; }

        public TimeSpan horario_inicio { get; private set; }

        public TimeSpan horario_fin { get; private set; }
    }
}
