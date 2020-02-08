using System.Data;

namespace Entity.Entidades
{
    public class Banco : Entidad
    {

        public Banco(IDataReader data)
        {
            id = (int)data["id"];
            banco_nombre = data["banco_nombre"].ToString();
            banco_estado = (bool)data["banco_estado"];
        }

        public int id { get; set; }
        public string banco_nombre { get; set; }
        public bool banco_estado { get; set; }
    }
}
