using System.Data;

namespace Entity.Entidades
{
    public class Tarjetas : Entidad
    {

        public Tarjetas(IDataReader data)
        {
            id = (int)data["id"];
            tarjeta_cliente = (int)data["tarjeta_cliente"];
            tarjeta_nombre_banco = data["tarjeta_nombre_banco"].ToString();
            tarjeta_numero = data["tarjeta_numero"].ToString();
            tarjeta_ccv = data["tarjeta_ccv"].ToString();
            tarjeta_ano = (int)data["tarjeta_ano"];
            tarjeta_mes = (int)data["tarjeta_mes"];
            tarjeta_dia = (int)data["tarjeta_dia"];
            tarjeta_propietario = data["tarjeta_propietario"].ToString();
        }

        public int id { get; set; }
        public int tarjeta_cliente { get; set; }
        public string tarjeta_nombre_banco { get; set; }
        public string tarjeta_numero { get; set; }
        public string tarjeta_ccv { get; set; }
        public int tarjeta_ano { get; set; }
        public int tarjeta_mes { get; set; }
        public int tarjeta_dia { get; set; }
        public string tarjeta_propietario { get; set; }
    }
}
