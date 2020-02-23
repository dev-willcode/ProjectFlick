using System.Windows.Forms;
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
                
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hey");
        }
    }
}
