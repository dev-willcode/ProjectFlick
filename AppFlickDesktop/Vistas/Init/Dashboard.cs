using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickCliente.Vistas.Forms;
using Utils;

namespace AppFlickCliente.Vistas.Init
{
    public partial class Dashboard : Form
    {
        List<Label> listaLabelsMenu;

        public Dashboard()
        {
            InitializeComponent();
            inicializarPropiedades();
            cargarDatos();
            btnFunciones_Click(null, null);
            timer.Start();
        }

        internal void cargarDatos()
        {
            if (PropiedadesGenerales.ClienteActual.cliente_imagen != null)
            {
                var_imagen_usuario.Image = Utils.UtilsProcedimientos.generarImagen(PropiedadesGenerales.ClienteActual.cliente_imagen);
            }
            var_nombre_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_nombres.Split(' ')[0];
        }

        private void inicializarPropiedades()
        {
            listaLabelsMenu = new List<Label>()
            {
                labelFunciones,labelFacturas, labelCuenta
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

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFunciones);
            pintarPantalla(new VistaFunciones_Cliente(this));
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFacturas);
            pintarPantalla(new VistaFacturas_Cliente(this));
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelCuenta);
            pintarPantalla(new VistaCuenta_Cliente(this));
        }

        private void pintarLabelMenu(Label seleccionado)
        {
            foreach (Label label in listaLabelsMenu)
            {
                label.BackColor = Color.FromArgb(29, 29, 29);
            }
            seleccionado.BackColor = Color.FromArgb(12, 109, 237);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var_hora_actual.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            PropiedadesGenerales.ClienteActual = null;
            new Login().Show();
            Close();
        }
    }
}
