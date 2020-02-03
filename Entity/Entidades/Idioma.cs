using System.Data;

namespace Entity.Entidades
{
    public class Idioma : Entidad
    {
        public Idioma()
        {
        }

        public Idioma(IDataReader data)
        {
            id = (int)data["id"];
            idioma_abreviatura = data["idioma_abreviatura"].ToString();
            idioma_descripcion = data["idioma_descripcion"].ToString();
        }

        public int id { get; set; }
        public string idioma_abreviatura { get; set; }
        public string idioma_descripcion { get; set; }
    }
}
