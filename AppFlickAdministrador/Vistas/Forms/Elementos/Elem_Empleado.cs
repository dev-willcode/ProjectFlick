using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Empleado : UserControl
    {
        public readonly Empleado empleado;
        private VistaEmpleados_Admin VistaEmpleados_Admin { get; set; }

        public Elem_Empleado() { }

        public Elem_Empleado(VistaEmpleados_Admin vistaEmpleados_Admin, Empleado empleado)
        {
            InitializeComponent();
            rellenarDatos(empleado);
            this.VistaEmpleados_Admin = vistaEmpleados_Admin;
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

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGenerales.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                try
                {
                    PropiedadesGenerales.EmpleadoController.Delete(empleado.id);
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Se ha eliminado el empleado");
                    VistaEmpleados_Admin.RellenarEmpleados();
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Form_Empleado form = new Form_Empleado(VistaEmpleados_Admin, "Editar empleado", empleado);
            form.ShowDialog();
        }
    }
}
