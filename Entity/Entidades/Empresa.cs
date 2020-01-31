namespace Entity.Entidades
{
    public class Empresa : Entidad
    {
        public Empresa()
        {
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
