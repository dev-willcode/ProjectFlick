using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaFacturas_Cliente : UserControl
    {
        private PanelScrollHelper scroll;
        private List<Elem_Factura> listaControles;
        private Label labelSinFacturas;
        public VistaFacturas_Cliente()
        {
            InitializeComponent();
            PropiedadesScroll();
            InicializarLabelSinFunciones();
            RellenarFacturas();
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelFacturas, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void InicializarLabelSinFunciones()
        {
            labelSinFacturas = new Label();
            labelSinFacturas.Visible = false;
            labelSinFacturas.Dock = DockStyle.Fill;
            labelSinFacturas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinFacturas.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinFacturas.Text = "No se encontraron facturas, que esperas para comprar tus boletos!";
            labelSinFacturas.TextAlign = ContentAlignment.MiddleCenter;
            panelFacturas.Controls.Add(labelSinFacturas);
        }

        private void RellenarFacturas()
        {
            List<Factura> lista = PropiedadesGenerales.FacturaController
                .ListarFacturas(PropiedadesGenerales.ClienteActual.id);
            listaControles = new List<Elem_Factura>();
            foreach (Factura factura in lista)
            {
                Elem_Factura elemento = new Elem_Factura(factura);
                panelFacturas.Controls.Add(elemento);
                elemento.Dock = DockStyle.Top;
                listaControles.Add(elemento);
                elemento.VisibleChanged += new EventHandler(EventoOcultar);
            }

        }
        private void EventoOcultar(object sender, EventArgs e)
        {
            int conteoVisibles = 0;
            listaControles.ForEach(elemento => { if (elemento.Visible) { conteoVisibles++; } });
            if (conteoVisibles == 0)
            {
                labelSinFacturas.Visible = true;
            }
            else
            {
                labelSinFacturas.Visible = false;
            }
        }



        private void FiltroFunciones()
        {
            if (string.IsNullOrEmpty(txtBuscarFactura.Text))
            {
                listaControles.ForEach(elemento => elemento.Visible = true);
            }
            else
            {
                foreach (Elem_Factura elemento in listaControles)
                {
                    if (!(elemento.CFacturaController.Factura.factura_numero
                        .Contains(txtBuscarFactura.Text) ||
                        elemento.CFacturaController.CFuncionesController.Pelicula
                        .pelicula_titulo.Contains(txtBuscarFactura.Text.ToUpper())))
                    {
                        elemento.Visible = false;
                    }
                }
            }
        }
        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            FiltroFunciones();
        }

        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            FiltroFunciones();
        }

        private void txtBuscarFactura_Enter(object sender, EventArgs e)
        {
            txtBuscarFactura.Text = "";
        }

        private void txtBuscarFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                FiltroFunciones();
            }
        }
    }
}
