using System;
using System.Data;

namespace Entity.Entidades.EntidadesPersonalizadas
{
    public class VistaFacturaDatos : Entidad
    {

        public VistaFacturaDatos(IDataReader data)
        {
            id = (int)data["id"];
            cliente_cedula = data["cliente_cedula"].ToString();
            cliente_apellidos = data["cliente_apellidos"].ToString();
            cliente_nombres = data["cliente_nombres"].ToString();
            cliente_telefono = data["cliente_telefono"].ToString();
            cliente_email = data["cliente_email"].ToString();
            cliente_direccion = data["cliente_direccion"].ToString();
            factura_numero = (int)data["factura_numero"];
            factura_fecha_emision = (DateTime)data["factura_fecha_emision"];
            factura_metodo_pago = data["factura_metodo_pago"].ToString();
            funcion_fecha_evento = (DateTime)data["funcion_fecha_evento"];
            funcion_precio_boleto = (decimal)data["funcion_precio_boleto"];
            sala_nombre = data["sala_nombre"].ToString();
            horario_inicio = (TimeSpan)data["horario_inicio"];
            idioma_abreviatura = data["idioma_abreviatura"].ToString();
            pelicula_titulo = data["pelicula_titulo"].ToString();
            pelicula_tipo_censura = data["pelicula_tipo_censura"].ToString();
            pelicula_duracion = data["pelicula_duracion"].ToString();
        }

        public int id { get; set; }

        public string cliente_cedula { get; set; }

        public string cliente_apellidos { get; set; }

        public string cliente_nombres { get; set; }

        public string cliente_telefono { get; set; }

        public string cliente_email { get; set; }

        public string cliente_direccion { get; set; }

        public int factura_numero { get; set; }

        public DateTime factura_fecha_emision { get; set; }

        public string factura_metodo_pago { get; set; }

        public DateTime funcion_fecha_evento { get; private set; }

        public decimal funcion_precio_boleto { get; private set; }

        public string sala_nombre { get; private set; }

        public TimeSpan horario_inicio { get; private set; }

        public string idioma_abreviatura { get; set; }

        public string pelicula_titulo { get; private set; }

        public string pelicula_tipo_censura { get; private set; }

        public string pelicula_duracion { get; private set; }
    }
}
