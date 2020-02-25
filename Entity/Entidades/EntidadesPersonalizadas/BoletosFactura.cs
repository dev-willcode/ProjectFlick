using System.Data;

namespace Entity.Entidades.EntidadesPersonalizadas
{
    public class BoletosFactura : Entidad
    {

        public BoletosFactura(IDataReader data)
        {
            cantidad = (int)data["cantidad"];
            asientos = data["asientos"].ToString();
            concepto = data["concepto"].ToString();
            precio_unitario = (decimal)data["precio_unitario"];
            importe = (decimal)data["importe"];
            iva = (decimal)data["iva"];
            total = (decimal)data["total"];
        }

        public int cantidad { get; set; }

        public string asientos { get; set; }

        public string concepto { get; set; }

        public decimal precio_unitario { get; set; }

        public decimal importe { get; private set; }

        public decimal iva { get; private set; }

        public decimal total { get; private set; }
    }
}
