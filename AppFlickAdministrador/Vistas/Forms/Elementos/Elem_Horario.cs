using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Horario : UserControl
    {
        public readonly Horarios horario;

        public Elem_Horario() { }

        public Elem_Horario(Horarios horario)
        {
            InitializeComponent();
            rellenarDatos(horario);
            this.horario = horario;
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
            Form_Horario form = new Form_Horario(horario);
            form.ShowDialog();
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {

        }
    }
}
