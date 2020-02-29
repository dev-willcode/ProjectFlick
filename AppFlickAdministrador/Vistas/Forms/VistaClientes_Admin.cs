using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Init;
using Controllers;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms
{
    public partial class VistaClientes_Admin : Vistas
    {
        private PanelScrollHelper scroll;
        private List<Elem_Cliente> listaControles;
        private Label labelSinClientes;

        public VistaClientes_Admin() { }

        public VistaClientes_Admin(Dashboard dashboard)
            : base(dashboard)
        {
            InitializeComponent();
            PropiedadesScroll();
            InicializarLabelSinFunciones();
            RellenarClientes();
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelContenedor, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void InicializarLabelSinFunciones()
        {
            labelSinClientes = new Label();
            labelSinClientes.Visible = false;
            labelSinClientes.Dock = DockStyle.Fill;
            labelSinClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinClientes.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinClientes.Text = "No se encontraron clientes, que esperas para comprar tus boletos!";
            labelSinClientes.TextAlign = ContentAlignment.MiddleCenter;
            panelContenedor.Controls.Add(labelSinClientes);
        }

        public void RellenarClientes()
        {
            try
            {
                panelContenedor.Controls.Clear();
                List<Cliente> lista = PropiedadesGenerales.ClienteController.ListarClientes();
                listaControles = new List<Elem_Cliente>();
                lista.ForEach(cliente =>
                {
                    Elem_Cliente elemento = new Elem_Cliente(this,cliente);
                    panelContenedor.Controls.Add(elemento);
                    elemento.Dock = DockStyle.Top;
                    listaControles.Add(elemento);
                    elemento.VisibleChanged += new EventHandler(EventoOcultar);
                });
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
        private void EventoOcultar(object sender, EventArgs e)
        {
            int conteoVisibles = 0;
            listaControles.ForEach(elemento => { if (elemento.Visible) { conteoVisibles++; } });
            if (conteoVisibles == 0)
            {
                labelSinClientes.Visible = true;
            }
            else
            {
                labelSinClientes.Visible = false;
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
                foreach (Elem_Cliente elemento in listaControles)
                {
                    if (!(elemento.cliente.cliente_nombres.Contains(txtBuscarFactura.Text) ||
                        elemento.cliente.cliente_apellidos.Contains(txtBuscarFactura.Text) ||
                        elemento.cliente.cliente_cedula.Contains(txtBuscarFactura.Text)))
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
