using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using AppFlickCliente.Vistas.Init;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class VistaFunciones_Cliente : Vistas
    {

        private PanelScrollHelper scroll;
        private List<Elem_funcion> listaControles;
        private Label labelSinFunciones;
        public VistaFunciones_Cliente() { }
        public VistaFunciones_Cliente(Dashboard dashboard)
            : base(dashboard)
        {
            InitializeComponent();
            PropiedadesScroll();
            InicializarLabelSinFunciones();
            RellenarFuncionesActivas();
        }

        private void RellenarFuncionesActivas()
        {
            try
            {
                List<VistaFunciones> listaFuncionesActivas = PropiedadesGenerales
                .VFuncionesController.ListarFuncionesActivas();
                listaControles = new List<Elem_funcion>();

                listaFuncionesActivas.ForEach(funcion =>
                {
                    Elem_funcion elemento = new Elem_funcion(funcion);
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
            labelSinFunciones.Text = "No se encontraron funciones disponibles actualmente :(";
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
            FiltroFunciones();
        }

        private void FiltroFunciones()
        {
                var busqueda = txtBuscarFuncion.Text.ToLower();
            if (string.IsNullOrEmpty(busqueda))
            {
                listaControles.ForEach(elemento => elemento.Visible = true);
            }
            else
            {
                string peliculaTitulo;
                string peliculaTituloOriginal;
                foreach (Elem_funcion elemento in listaControles)
                {
                    peliculaTitulo = elemento.funcion.pelicula_titulo.ToLower();
                    peliculaTituloOriginal = elemento.funcion.pelicula_titulo.ToLower();
                    elemento.Visible = peliculaTitulo.Contains(busqueda) || peliculaTituloOriginal.Contains(busqueda);
                }
            }
        }

        private void TxtBuscarFuncion_TextChanged(object sender, EventArgs e)
        {
            FiltroFunciones();
        }

        private void TxtBuscarFuncion_Enter(object sender, EventArgs e)
        {
            txtBuscarFuncion.Text = "";
        }

        private void txtBuscarFuncion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                FiltroFunciones();
            }
        }

        private void txtBuscarFuncion_KeyDown(object sender, KeyEventArgs e)
        {
            FiltroFunciones();
        }
    }
}
