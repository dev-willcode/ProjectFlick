using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Entidades
{
    class Boleto
    {
      
        public Boleto()
        {
        }

        public int id { get; private set; }

        public int boleto_factura { get; private set; }

        public int boleto_funcion { get; private set; }

        public string boleto_asiento { get; private set; }

        public string boleto_tipo_asiento { get; private set; }

        public string boleto_medio_compra { get; private set; }

        public double boleto_descuento { get; private set; }
    }
}
