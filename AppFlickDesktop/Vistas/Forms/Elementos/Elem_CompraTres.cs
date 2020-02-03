using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Elem_CompraTres : Elem_Compra
    {
        public Elem_CompraTres(Form_Comprar form)
        {
            InitializeComponent();
            this.FormPadre = form;
        }
    }
}
