using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Init;
using FlickLibrary.Entidades;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class VistaFunciones_Cliente : UserControl
    {
        PanelScrollHelper scroll;
        public VistaFunciones_Cliente()
        {
            InitializeComponent();
            rellenarFunciones();
            propiedadesScroll();
        }
        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelFunciones, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void rellenarFunciones()
        {
            for (int i = 0; i < 10; i++)
            {
                Elem_funcion elemento = new Elem_funcion();
                panelFunciones.Controls.Add(elemento);
                elemento.Dock = DockStyle.Top;
                Factura fact = new Factura();
            }
        }
    }
}
