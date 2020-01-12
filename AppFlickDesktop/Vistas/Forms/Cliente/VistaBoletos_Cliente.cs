using System.Windows.Forms;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class VistaBoletos_Cliente : UserControl
    {
        PanelScrollHelper scroll;
        public VistaBoletos_Cliente()
        {
            InitializeComponent();
            rellenarBoletos();
            propiedadesScroll();
        }
        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(tablaBoletos, scrollBar, true);
            scroll.UpdateScrollBar();
        }
        private void rellenarBoletos()
        {
            for (int i = 0; i < 13; i++)
            {
                Elem_boleto elemento = new Elem_boleto();
                tablaBoletos.Controls.Add(elemento);
                elemento.Dock = DockStyle.Fill;
            }
        }
    }
}
