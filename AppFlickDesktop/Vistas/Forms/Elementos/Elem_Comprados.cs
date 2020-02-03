using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Elem_CompraDos : Elem_Compra
    {
        public Elem_CompraDos(Form_Comprar form)
        {
            InitializeComponent();
            this.FormPadre = form;
        }

        private void btnContinuar_Click(object sender, System.EventArgs e)
        {
            this.Confirmado = true;
            FormPadre.CambiarATres(sender, e);
        }
    }
}
