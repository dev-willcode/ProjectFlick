using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms;
using Entity.Entidades;
using Utils;

namespace AppFlickDesktop.Vistas.Init
{
    public partial class Dashboard : Form
    {
        List<Label> listaLabelsMenu;

        public Dashboard()
        {
            InitializeComponent();
            inicializarPropiedades();
        }
        private void inicializarPropiedades()
        {
            listaLabelsMenu = new List<Label>()
            {
                labelInicio,labelFunciones,labelFacturas, labelCuenta
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

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFacturas);
            pintarPantalla(new VistaFacturas_Cliente());
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelCuenta);
            pintarPantalla(new VistaCuenta_Cliente());
        }

        private void pintarLabelMenu(Label seleccionado)
        {
            foreach (Label label in listaLabelsMenu)
            {
                label.BackColor = Color.FromArgb(29, 29, 29);
            }
            seleccionado.BackColor = Color.FromArgb(12, 109, 237);
        }

        internal void asignarUsuario(Cliente cliente)
        {
            PropiedadesGenerales.ClienteActual = cliente;
        }
    }
}
