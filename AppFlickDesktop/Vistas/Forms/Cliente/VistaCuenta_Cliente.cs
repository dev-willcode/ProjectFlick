using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class VistaCuenta_Cliente : UserControl
    {
        PanelScrollHelper scroll;
        public VistaCuenta_Cliente()
        {
            InitializeComponent();
            propiedadesScroll();
            rellenarTarjetas();
        }
        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelPrincipal, scrollBar, true);
            scroll.UpdateScrollBar();
        }
        private void rellenarTarjetas()
        {
            for (int i = 0; i < 2; i++)
            {
                Elem_tarjeta elemento = new Elem_tarjeta();
                panelPrincipal.Controls.Add(elemento);
                elemento.Dock = DockStyle.Left;
            }
        }
    }
}
