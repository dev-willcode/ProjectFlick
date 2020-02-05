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
        }

        public int id { get; private set; }

        public int funcion_pelicula { get; private set; }

        public int funcion_sala { get; private set; }

        public DateTime funcion_fecha_evento { get; private set; }

        public int funcion_horario { get; private set; }

        public string funcion_estado { get; private set; }

        public decimal funcion_precio_boleto { get; private set; }

        public DateTime funcion_fecha_creacion { get; private set; }

        public int funcion_idioma { get; private set; }
    }
}
