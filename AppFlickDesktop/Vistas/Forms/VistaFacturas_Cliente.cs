using System.Collections.Generic;
using System.Windows.Forms;
using Controllers.Controller;
using Entity.Entidades;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaFacturas_Cliente : UserControl
    {
        public VistaFacturas_Cliente()
        {
            InitializeComponent();
        }

        private void btnBuscarFactura_Click(object sender, System.EventArgs e)
        {
            FacturaController factura = new FacturaController();
            List<Factura> list = factura.ListarFacturas(1);
        }
    }
}
