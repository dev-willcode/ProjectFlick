using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Dashboard : Form
    {
        List<Label> listaLabelsMenu;

        public Dashboard()
        {
            InitializeComponent();
            inicializarPropiedades();
            cargarDatos();
            timer.Start();
        }

        internal void cargarDatos()
        {
            var_nombre_usuario.Text = PropiedadesGenerales.EmpleadoActual.empleado_nombres.Split(' ')[0];
            btnFunciones_Click(null, null);
        }

        private void inicializarPropiedades()
        {
            listaLabelsMenu = new List<Label>()
            {
                labelFunciones, labelPeliculas, labelHorarios, labelFacturacion, labelClientes, labelEmpleados
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
            PropiedadesGenerales.EmpleadoActual = null;
            new Login().Show();
            Close();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFunciones);
            pintarPantalla(new VistaFunciones_Admin(this));
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelPeliculas);
            pintarPantalla(new VistaPelicula_Admin(this));
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelHorarios);
            pintarPantalla(new VistaHorarios_Admin(this));
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            pintarLabelMenu(labelFacturacion);
            pintarPantalla(new VistaFacturacion_Admin(this));
        }
    }
}
