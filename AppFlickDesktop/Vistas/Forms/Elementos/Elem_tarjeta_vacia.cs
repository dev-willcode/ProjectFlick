using System;
using System.Windows.Forms;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public partial class Elem_tarjeta_vacia : UserControl
    {
        private VistaCuenta_Cliente VistaCuenta_Cliente { get; set; }

        public Elem_tarjeta_vacia() { }

        public Elem_tarjeta_vacia(VistaCuenta_Cliente vistaCuenta_Cliente)
        {
            VistaCuenta_Cliente = vistaCuenta_Cliente;
            InitializeComponent();
        }

        private void btnMasTarjetas_Click(object sender, EventArgs e)
        {
            /* este elemento solo sirve para llamar al formulario Form_tarjeta*/
            Form_Tarjeta form = new Form_Tarjeta(VistaCuenta_Cliente);
            form.ShowDialog();
        }
    }
}
