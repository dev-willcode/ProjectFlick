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
    public partial class VistaPelicula_Admin : Vistas
    {
        private PanelScrollHelper scroll;
        private List<Elem_pelicula> listaControles;
        private Label labelSinFunciones;
        public VistaPelicula_Admin() { }
        public VistaPelicula_Admin(Dashboard dashboard)
            : base(dashboard)
        {
            InitializeComponent();
            PropiedadesScroll();
            InicializarLabelSinFunciones();
            RellenarPeliculas();
        }

        private void RellenarPeliculas()
        {
            try
            {
                List<Pelicula> listaFuncionesActivas = PropiedadesGenerales
                    .VPeliculasController.ListarPeliculas();
                listaControles = new List<Elem_pelicula>();

                listaFuncionesActivas.ForEach(pelicula =>
                {
                    Elem_pelicula elemento = new Elem_pelicula(pelicula);
                    panelFunciones.Controls.Add(elemento);
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

        private void InicializarLabelSinFunciones()
        {
            labelSinFunciones = new Label();
            labelSinFunciones.Visible = false;
            labelSinFunciones.Dock = DockStyle.Fill;
            labelSinFunciones.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinFunciones.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinFunciones.Text = "No se encontraron peliculas actualmente :(";
            labelSinFunciones.TextAlign = ContentAlignment.MiddleCenter;
            panelFunciones.Controls.Add(labelSinFunciones);
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelFunciones, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void EventoOcultar(object sender, EventArgs e)
        {
            int conteoVisibles = 0;
            listaControles.ForEach(elemento => { if (elemento.Visible) { conteoVisibles++; } });
            if (conteoVisibles == 0)
            {
                labelSinFunciones.Visible = true;
            }
            else
            {
                labelSinFunciones.Visible = false;
            }
        }

        private void BtnBuscarFuncion_Click(object sender, EventArgs e)
        {
            FiltroPeliculas();
        }

        private void FiltroPeliculas()
        {
            if (string.IsNullOrEmpty(txtBuscarFuncion.Text))
            {
                listaControles.ForEach(elemento => elemento.Visible = true);
            }
            else
            {
                foreach (Elem_pelicula elemento in listaControles)
                {
                    if (!(elemento.Pelicula.pelicula_titulo.Contains(txtBuscarFuncion.Text.ToUpper()) ||
                        elemento.Pelicula.pelicula_titulo_original.Contains(txtBuscarFuncion.Text.ToUpper())))
                    {
                        elemento.Visible = false;
                    }
                }
            }
        }

        private void TxtBuscarFuncion_TextChanged(object sender, EventArgs e)
        {
            FiltroPeliculas();
        }

        private void TxtBuscarFuncion_Enter(object sender, EventArgs e)
        {
            txtBuscarFuncion.Text = "";
        }

        private void txtBuscarFuncion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                FiltroPeliculas();
            }
        }
    }
}
