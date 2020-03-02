using System;
using System.Data.SqlClient;

namespace Entity.Entidades.EntidadesPersonalizadas
{
    public class VistaFunciones : Entidad
    {
        public VistaFunciones(SqlDataReader data)
        {
            id = (int)data["id"];
            funcion_pelicula = (int)data["funcion_pelicula"];
            pelicula_titulo = data["pelicula_titulo"].ToString();
            pelicula_titulo_original = data["pelicula_titulo_original"].ToString();
            idioma_abreviatura = data["idioma_abreviatura"].ToString();
            horario_inicio = (TimeSpan)data["horario_inicio"];
            pelicula_duracion = data["pelicula_duracion"].ToString();
            pelicula_tipo_censura = data["pelicula_tipo_censura"].ToString();
            pelicula_imagen = data["pelicula_imagen"] == DBNull.Value ?
                null : (byte[])data["pelicula_imagen"];
            pelicula_url_trailer = data["pelicula_url_trailer"].ToString();
            pelicula_sinopsis = data["pelicula_sinopsis"].ToString();
            pelicula_director = data["pelicula_director"].ToString();
            pelicula_reparto = data["pelicula_reparto"].ToString();
            funcion_fecha_evento = (DateTime)data["funcion_fecha_evento"];
            funcion_estado = data["funcion_estado"].ToString();
            funcion_precio_boleto = (decimal)data["funcion_precio_boleto"];
            sala_nombre = data["sala_nombre"].ToString();
            idioma_descripcion = data["idioma_descripcion"].ToString();
            funcion_asientos_disponibles = (int)data["funcion_asientos_disponibles"];
            funcion_fecha_creacion = (DateTime)data["funcion_fecha_creacion"];
        }

        public int id { get; set; }
        public int funcion_pelicula { get; set; }
        public string pelicula_titulo { get; set; }
        public string pelicula_titulo_original { get; set; }
        public string idioma_abreviatura { get; set; }
        public TimeSpan horario_inicio { get; set; }
        public string pelicula_duracion { get; set; }
        public string pelicula_tipo_censura { get; set; }
        public byte[] pelicula_imagen { get; set; }
        public string pelicula_url_trailer { get; set; }
        public string categorias { get; set; }
        public string pelicula_sinopsis { get; set; }
        public string pelicula_director { get; set; }
        public string pelicula_reparto { get; set; }
        public DateTime funcion_fecha_evento { get; set; }
        public string funcion_estado { get; set; }
        public decimal funcion_precio_boleto { get; set; }
        public string sala_nombre { get; set; }
        public string idioma_descripcion { get; set; }
        public int funcion_asientos_disponibles { get; set; }
        public DateTime funcion_fecha_creacion { get; set; }

    }
}
