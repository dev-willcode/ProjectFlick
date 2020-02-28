using System;
using System.Data.SqlClient;

namespace Entity.Entidades.EntidadesPersonalizadas
{
    public class VistaFacturaAdmin : Entidad
    {
        public VistaFacturaAdmin(SqlDataReader data)
        {
            id = (int)data["id"];
            factura_numero = data["factura_numero"].ToString();
            cliente_nombres = data["cliente_nombres"].ToString();
            cliente_apellidos = data["cliente_apellidos"].ToString();
            pelicula_titulo = data["pelicula_titulo"].ToString();
            factura_fecha_emision = (DateTime)data["factura_fecha_emision"];
            factura_estado = data["factura_estado"].ToString();
            funcion_precio_boleto = (decimal)data["funcion_precio_boleto"];
            numero_boletos = (int)data["numero_boletos"];
        }

        public int id { get; set; }

        public string factura_numero { get; set; }

        public string pelicula_titulo { get; set; }

        public string cliente_nombres { get; set; }

        public string cliente_apellidos { get; set; }

        public DateTime factura_fecha_emision { get; set; }

        public string factura_estado { get; set; }

        public decimal funcion_precio_boleto { get; set; }

        public int numero_boletos { get; set; }
    }
}
