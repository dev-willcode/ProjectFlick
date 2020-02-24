using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Controllers.Controller;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Horario : UserControl
    {
        public readonly Horarios Horario;
        private VistaHorarios_Admin VistaHorarios_Admin { get; set; }

        public Elem_Horario() { }

        public Elem_Horario(VistaHorarios_Admin vistaHorarios_Admin, Horarios horario)
        {
            Horario = horario;
            VistaHorarios_Admin = vistaHorarios_Admin;
            InitializeComponent();
            rellenarDatos(horario);
            
        }

        private void rellenarDatos(Horarios horario)
        {
            try
            {
                labelHoraInicio.Text = horario.horario_inicio.ToString();
                labelHoraFin.Text = horario.horario_fin.ToString();
            }
            catch (ControllerException ex)
            {
                PropiedadesGeneralesA.Notificar.notificarError(ex);
            }
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hey");
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Form_Horario form = new Form_Horario(VistaHorarios_Admin,Horario);
            form.control = 1;
            form.ShowDialog();
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGeneralesA.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                if (HorarioController.EliminarHorario(Horario.id))
                {
                    PropiedadesGeneralesA.Notificar.notificarCorrecto("Completado", "Se ha eliminado el horario");
                    VistaHorarios_Admin.RellenarHorarios();
                }
                else
                {
                    PropiedadesGeneralesA.Notificar.notificarFallo("Eliminación Cancelada", "No se ha borrado el horario");
                }
            }
        }
    }
}
