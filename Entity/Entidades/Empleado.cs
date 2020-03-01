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

        public int id { get;  set; }

        public string empleado_cedula { get;  set; }

        public string empleado_nombres { get;  set; }

        public string empleado_apellidos { get;  set; }

        public string empleado_telefono { get;  set; }

        public string empleado_email { get;  set; }

        public string empleado_direccion { get;  set; }

        public int empleado_usuario { get;  set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Empleado empleado = obj as Empleado;
            return empleado_cedula == empleado.empleado_cedula &&
                empleado_nombres == empleado.empleado_nombres &&
                empleado_apellidos == empleado.empleado_apellidos &&
                empleado_telefono == empleado.empleado_telefono &&
                empleado_email == empleado.empleado_email &&
                empleado_direccion == empleado.empleado_direccion;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
