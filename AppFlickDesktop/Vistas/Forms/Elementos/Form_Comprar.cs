using System;
using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Form_Comprar : Form
    {
        public Form_Comprar()
        {
            InitializeComponent();
        }

        private void anadirPanelCentral(UserControl elem)
        {
            contenedor.Controls.Clear();
            contenedor.Controls.Add(elem);
            elem.Dock = DockStyle.Fill;
        }

        private void btnCompraUno_Click(object sender, System.EventArgs e)
        {
            anadirPanelCentral(new Elem_CompraUno());
        }

        private void btnCompraDos_Click(object sender, EventArgs e)
        {
            anadirPanelCentral(new Elem_CompraDos());
        }

        private void btnCompraTres_Click(object sender, EventArgs e)
        {
            anadirPanelCentral(new Elem_CompraTres());
        }
    }
}
