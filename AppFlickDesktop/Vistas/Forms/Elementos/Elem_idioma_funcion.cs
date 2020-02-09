using System.Windows.Forms;
using Entity.Entidades;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Elem_idioma_funcion : UserControl
    {
        public Elem_idioma_funcion()
        {
            InitializeComponent();
        }

        public Elem_idioma_funcion(Idioma idioma)
        {
            InitializeComponent();
            var_idioma.Text = idioma.idioma_abreviatura;
        }
    }
}
