using System;

namespace Entity.Entidades
{
    public class Horarios : Entidad
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
