using System.Data;

namespace Entity.Entidades
{
    public class Boleto : Entidad
    {
        public Boleto()
        {
        }

        public Boleto(IDataReader data)
        {
            id = (int)data["id"];
            boleto_factura = (int)data["boleto_factura"];
            boleto_funcion = (int)data["boleto_funcion"];
            boleto_asiento = data["boleto_asiento"].ToString();
            boleto_tipo_asiento = data["boleto_tipo_asiento"].ToString();
            boleto_medio_compra = data["boleto_medio_compra"].ToString();
        }

        public int id { get; set; }

        public int boleto_factura { get; set; }

        public int boleto_funcion { get; set; }

        public string boleto_asiento { get; set; }

        public string boleto_tipo_asiento { get; set; }

        public string boleto_medio_compra { get; set; }
    }
}
