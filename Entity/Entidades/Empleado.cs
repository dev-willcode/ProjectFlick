using System.Data;

namespace Entity.Entidades
{
    public class Empleado : Entidad
    {

        public Empleado()
        {
        }

        public Empleado(IDataReader data)
        {
            id = (int)data["id"];
            empleado_cedula = data["empleado_cedula"].ToString();
            empleado_nombres = data["empleado_nombres"].ToString();
            empleado_apellidos = data["empleado_apellidos"].ToString();
            empleado_telefono = data["empleado_telefono"].ToString();
            empleado_email = data["empleado_email"].ToString();
            empleado_direccion = data["empleado_direccion"].ToString();
            empleado_usuario = (int)data["empleado_usuario"];
        }

        public int id { get; private set; }

        public string empleado_cedula { get; private set; }

        public string empleado_nombres { get; private set; }

        public string empleado_apellidos { get; private set; }

        public string empleado_telefono { get; private set; }

        public string empleado_email { get; private set; }

        public string empleado_direccion { get; private set; }

        public int empleado_usuario { get; private set; }
    }
}
