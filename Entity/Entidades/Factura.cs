using System;

namespace Entity.Entidades
{
    public class Factura
    {
        public Factura()
        {
        }

        public int id { get; private set; }

        public int factura_cliente { get; private set; }

        public int factura_funcion { get; private set; }

        public string factura_numero { get; private set; }

        public string factura_metodo_pago { get; private set; }

        public DateTime factura_fecha_emision { get; private set; }

    }
}
