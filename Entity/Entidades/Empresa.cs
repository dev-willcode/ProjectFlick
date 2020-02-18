using System.Data;

namespace Entity.Entidades
{
    public class Empresa : Entidad
    {

        public Empresa(IDataReader data)
        {
            id = (int)data["id"];
            empresa_razon_social = data["empresa_razon_social"].ToString();
            empresa_numero_contribuyente = data["empresa_numero_contribuyente"].ToString();
            empresa_numero_autorizacion = data["empresa_numero_autorizacion"].ToString();
            empresa_direccion = data["empresa_direccion"].ToString();
            empresa_telefono = data["empresa_telefono"].ToString();
            empresa_email = data["empresa_email"].ToString();
            empresa_website = data["empresa_website"].ToString();
            empresa_ambiente = data["empresa_ambiente"].ToString();
            empresa_contabilidad = (bool)data["empresa_contabilidad"];
        }

        public int id { get; private set; }

        public string empresa_razon_social { get; private set; }

        public string empresa_numero_contribuyente { get; private set; }

        public string empresa_numero_autorizacion { get; private set; }

        public string empresa_direccion { get; private set; }

        public string empresa_telefono { get; private set; }

        public string empresa_email { get; private set; }

        public string empresa_website { get; private set; }

        public string empresa_ambiente { get; private set; }

        public bool empresa_contabilidad { get; private set; }
    }
}
