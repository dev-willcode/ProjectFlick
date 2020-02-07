using System.Collections.Generic;
using System.Windows.Forms;
using Controllers.Controller;
using Entity.Entidades;
using Utils;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaFacturas_Cliente : UserControl
    {
        private List<Control> listaControles;
        public VistaFacturas_Cliente()
        {
            InitializeComponent();
        }

        private void btnBuscarFactura_Click(object sender, System.EventArgs e)
        {
            List<Factura> lista = PropiedadesGenerales.FacturaController.ListarFacturas(PropiedadesGenerales.ClienteActual.id);
            listaControles = new List<Control>();
            foreach (Factura factura in lista)
            {
                Elem_Factura elemento = new Elem_Factura(factura);
                panelFacturas.Controls.Add(elemento);
                elemento.Dock = DockStyle.Top;
                listaControles.Add(elemento);
            }
        }
    }
}
