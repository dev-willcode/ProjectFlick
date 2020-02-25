using System;
using System.Data.SqlClient;

namespace Entity.Entidades.EntidadesPersonalizadas
{
    public class VistaFacturaFuncion : Entidad
    {
        public VistaFacturaFuncion(SqlDataReader data)
        {
            id = (int)data["id"];
            factura_funcion = (int)data["factura_funcion"];
            factura_cliente = (int)data["factura_cliente"];
            funcion_precio_boleto = (decimal)data["funcion_precio_boleto"];
            factura_numero = data["factura_numero"].ToString();
            pelicula_titulo = data["pelicula_titulo"].ToString();
            idioma_abreviatura = data["idioma_abreviatura"].ToString();
            funcion_fecha_evento = data["funcion_fecha_evento"].ToString();
            horario_inicio = (TimeSpan)data["horario_inicio"];
            factura_fecha_emision = (DateTime)data["factura_fecha_emision"];
            numero_boletos = (int)data["numero_boletos"];
        }

        public int id { get; set; }
        public int factura_funcion { get; set; }
        public int factura_cliente { get; set; }
        public decimal funcion_precio_boleto { get; set; }
        public string factura_numero { get; set; }
        public string pelicula_titulo { get; set; }
        public string idioma_abreviatura { get; set; }
        public string funcion_fecha_evento { get; set; }
        public TimeSpan horario_inicio { get; set; }
        public DateTime factura_fecha_emision { get; set; }
        public int numero_boletos { get; set; }
    }
}
