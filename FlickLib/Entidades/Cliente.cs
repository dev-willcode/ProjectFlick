using System.Data;
namespace FlickLib.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(string cliente_cedula, string cliente_apellidos, string cliente_nombres, 
            string cliente_telefono, string cliente_email, string cliente_direccion, int cliente_usuario)
        {
            this.cliente_cedula = cliente_cedula;
            this.cliente_apellidos = cliente_apellidos;
            this.cliente_nombres = cliente_nombres;
            this.cliente_telefono = cliente_telefono;
            this.cliente_email = cliente_email;
            this.cliente_direccion = cliente_direccion;
            this.cliente_usuario = cliente_usuario;
        }

        public Cliente(IDataReader data)
        {
            id = (int)data["id"];
            cliente_cedula = data["cliente_cedula"].ToString();
            cliente_apellidos = data["cliente_apellidos"].ToString();
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
