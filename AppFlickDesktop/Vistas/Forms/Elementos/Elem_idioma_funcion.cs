using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class Elem_idioma_funcion : UserControl
    {
        public Elem_idioma_funcion()
        {
            InitializeComponent();
        }

        public Elem_idioma_funcion(string idioma)
        {
            InitializeComponent();
            var_idioma.Text = idioma;
        }
    }
}
