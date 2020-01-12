using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms.Cliente;

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
                labelInicio,labelFunciones,labelBoletos,labelTarjetas, labelCuenta
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
            pintarPantalla(new Funciones_Cliente());
        }

        private void btnBoletos_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelBoletos);
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelTarjetas);
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelCuenta);
        }

        private void pintarLabelMenu(Label seleccionado)
        {
            foreach (Label label in listaLabelsMenu)
            {
                label.BackColor = Color.FromArgb(29, 29, 29);
            }
            seleccionado.BackColor = Color.FromArgb(12, 109, 237);
        }
    }
}
