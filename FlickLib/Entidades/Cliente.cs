using System.Data;
namespace FlickLib.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(IDataReader data)
        {
            id = (int)data["id"];
            cliente_cedula = data["cliente_cedula"].ToString();
            cliente_apellidos = data["cliente_apellidos"].ToString();
            cliente_nombres = data["cliente_nombres"].ToString();
            cliente_telefono = data["cliente_telefono"].ToString();
            cliente_email = data["cliente_email"].ToString();
            cliente_direccion = data["cliente_direccion"].ToString();
            cliente_usuario = (int)data["cliente_usuario"];
        }

        public int id { get; set; }

        public string cliente_cedula { get; set; }

        public string cliente_apellidos { get; set; }

        public string cliente_nombres { get; set; }

        public string cliente_telefono { get; set; }

        public string cliente_email { get; set; }

        public string cliente_direccion { get; set; }

        public int cliente_usuario { get; set; }
    }
}
