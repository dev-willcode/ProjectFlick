using System.Windows.Forms;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Empleado : UserControl
    {
        public readonly Empleado empleado;

        public Elem_Empleado() { }

        public Elem_Empleado(Empleado empleado)
        {
            InitializeComponent();
            rellenarDatos(empleado);
            this.empleado = empleado;
        }

        private void rellenarDatos(Empleado empleado)
        {
            try
            {
                var_cedula.Text = empleado.empleado_cedula;
                var_nombre_completo.Text = empleado.empleado_apellidos + " " + empleado.empleado_nombres;
                var_direccion.Text = empleado.empleado_direccion;
                var_email.Text = empleado.empleado_email;
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
