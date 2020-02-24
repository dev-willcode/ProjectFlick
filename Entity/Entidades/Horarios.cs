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

        public int id { get;  set; }

        public TimeSpan horario_inicio { get;  set; }

        public TimeSpan horario_fin { get;  set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Horarios horario = obj as Horarios;
            return horario_fin == horario.horario_fin &&
                horario_fin == horario.horario_fin;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
