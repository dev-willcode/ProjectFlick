using System;
using System.Data;

namespace Entity.Entidades
{
    public class Factura : Entidad
    {
        public Factura()
        {
        }
        public Factura(IDataReader data)
        {
            id = (int)data["id"];
            factura_cliente = (int)data["factura_cliente"];
            factura_funcion = (int)data["factura_funcion"];
            factura_numero = data["factura_numero"].ToString();
            factura_metodo_pago = data["factura_metodo_pago"].ToString();
            factura_fecha_emision = (DateTime)data["factura_fecha_emision"];
        }

        public int id { get; set; }

        public int factura_cliente { get; set; }

        public int factura_funcion { get; set; }

        public string factura_numero { get; set; }

        public string factura_metodo_pago { get;  set; }

        public DateTime factura_fecha_emision { get; set; }

    }
}
