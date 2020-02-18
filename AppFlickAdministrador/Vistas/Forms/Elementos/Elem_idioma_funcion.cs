using System.Windows.Forms;

namespace AppFlickAdministrador.Vistas.Forms
{
    public partial class Elem_idioma_funcion : UserControl
    {
        public Elem_idioma_funcion()
        {
            InitializeComponent();
        }
        public Elem_idioma_funcion(string idioma_abreviatura)
        {
            InitializeComponent();
            var_idioma.Text = idioma_abreviatura;
        }
    }
}
