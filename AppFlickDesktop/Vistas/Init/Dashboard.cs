using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms.Cliente;
using AppFlickDesktop.Vistas.Notificaciones;
using FlickLib.Entidades;

namespace AppFlickDesktop.Vistas.Init
{
    public partial class Dashboard : Form
    {
        private Cliente cliente;
        List<Label> listaLabelsMenu;

        public static Notificar Notificar { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            inicializarPropiedades();
        }
        private void inicializarPropiedades()
        {
            listaLabelsMenu = new List<Label>()
            {
                labelInicio,labelFunciones,labelBoletos,labelFacturas, labelCuenta
            };
        }
        private void animacion_logo(object sender, EventArgs e)
        {
            animacionLogo.HideSync(logoImagen);
            animacionLogo.ShowSync(logoImagen);
        }

        private void pintarPantalla(UserControl pantalla)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(pantalla);
            pantalla.Dock = DockStyle.Fill;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelInicio);
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFunciones);
            pintarPantalla(new VistaFunciones_Cliente());
        }

        private void btnBoletos_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelBoletos);
            pintarPantalla(new VistaBoletos_Cliente());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFacturas);
            pintarPantalla(new VistaFacturas_Cliente());
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelCuenta);
            pintarPantalla(new VistaCuenta_Cliente(cliente));
        }

        private void pintarLabelMenu(Label seleccionado)
        {
            foreach (Label label in listaLabelsMenu)
            {
                label.BackColor = Color.FromArgb(29, 29, 29);
            }
            seleccionado.BackColor = Color.FromArgb(12, 109, 237);
        }

        internal void asignarUsuario(FlickLib.Entidades.Cliente cliente)
        {
            this.cliente = cliente;
        }
    }
}
