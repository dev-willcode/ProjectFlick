using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Init;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms
{
    public partial class VistaFunciones_Admin : Vistas
    {
        private PanelScrollHelper scroll;
        private List<Elem_funcion> listaControles;
        private Label labelSinFunciones;
        public VistaFunciones_Admin() { }
        public VistaFunciones_Admin(Dashboard dashboard)
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
                    .VFuncionesController.ListarFunciones();
                listaControles = new List<Elem_funcion>();

                listaFuncionesActivas.ForEach(funcion =>
                {
                    Elem_funcion elemento = new Elem_funcion(funcion);
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

        private void InicializarLabelSinFunciones()
        {
            labelSinFunciones = new Label();
            labelSinFunciones.Visible = false;
            labelSinFunciones.Dock = DockStyle.Fill;
            labelSinFunciones.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinFunciones.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinFunciones.Text = "No se encontraron funciones disponibles actualmente :(";
            labelSinFunciones.TextAlign = ContentAlignment.MiddleCenter;
            panelContenedor.Controls.Add(labelSinFunciones);
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelContenedor, scrollBar, true);
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
            if (string.IsNullOrEmpty(txtBuscarFuncion.Text))
            {
                listaControles.ForEach(elemento => elemento.Visible = true);
            }
            else
            {
                foreach (Elem_funcion elemento in listaControles)
                {
                    if (!(elemento.funcion.pelicula_titulo.Contains(txtBuscarFuncion.Text.ToUpper()) ||
                        elemento.funcion.pelicula_titulo_original.Contains(txtBuscarFuncion.Text.ToUpper())))
                    {
                        elemento.Visible = false;
                    }
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
    }
}
