using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Horario : UserControl
    {
        public readonly Horario Horario;
        private VistaHorarios_Admin VistaHorarios_Admin { get; set; }

        public Elem_Horario() { }

        public Elem_Horario(VistaHorarios_Admin vistaHorarios_Admin, Horario horario)
        {
            Horario = horario;
            VistaHorarios_Admin = vistaHorarios_Admin;
            InitializeComponent();
            rellenarDatos(horario);

        }

        private void rellenarDatos(Horario horario)
        {
            try
            {
                labelHoraInicio.Text = horario.horario_inicio.ToString();
                labelHoraFin.Text = horario.horario_fin.ToString();
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Form_Horario form = new Form_Horario(VistaHorarios_Admin, "Editar horario", Horario);
            form.ShowDialog();
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGenerales.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                try
                {
                    PropiedadesGenerales.HorarioController.Delete(Horario.id);
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Se ha eliminado el horario");
                    VistaHorarios_Admin.RellenarHorarios();
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
        }
    }
}
