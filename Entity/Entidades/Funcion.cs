using System;
using System.Data;

namespace Entity.Entidades
{
    public class Funcion : Entidad
    {
        public Funcion()
        {
        }
        public Funcion(IDataReader data)
        {
            id = (int)data["id"];
            funcion_pelicula = (int)data["funcion_pelicula"];
            funcion_sala = (int)data["funcion_sala"];
            funcion_fecha_evento = (DateTime)data["funcion_fecha_evento"];
            funcion_horario = (int)data["funcion_horario"];
            funcion_estado = data["funcion_estado"].ToString();
            funcion_precio_boleto = (decimal)data["funcion_precio_boleto"];
            funcion_fecha_creacion = (DateTime)data["funcion_fecha_creacion"];
            funcion_idioma = (int)data["funcion_idioma"];
            funcion_asientos_disponibles = (int)data["funcion_asientos_disponibles"];
        }

        public int id { get;  set; }

        public int funcion_pelicula { get;  set; }

        public int funcion_sala { get;  set; }

        public DateTime funcion_fecha_evento { get;  set; }

        public int funcion_horario { get;  set; }

        public string funcion_estado { get;  set; }

        public decimal funcion_precio_boleto { get;  set; }

        public DateTime funcion_fecha_creacion { get;  set; }

        public int funcion_idioma { get;  set; }

        public int funcion_asientos_disponibles { get;  set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Funcion funcion = obj as Funcion;
            return funcion_pelicula == funcion.funcion_pelicula &&
                funcion_sala == funcion.funcion_sala &&
                funcion_fecha_evento == funcion.funcion_fecha_evento &&
                funcion_horario == funcion.funcion_horario &&
                funcion_estado == funcion.funcion_estado &&
                funcion_precio_boleto == funcion.funcion_precio_boleto &&
                funcion_fecha_creacion == funcion.funcion_fecha_creacion &&
                funcion_idioma == funcion.funcion_idioma &&
                funcion_asientos_disponibles == funcion.funcion_asientos_disponibles;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
