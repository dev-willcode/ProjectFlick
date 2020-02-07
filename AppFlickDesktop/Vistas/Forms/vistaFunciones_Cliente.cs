using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Init;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaFunciones_Cliente : UserControl
    {

        private PanelScrollHelper scroll;
        private List<Control> listaControles;
        private Label labelSinFunciones;
        public VistaFunciones_Cliente()
        {
            InitializeComponent();
            PropiedadesScroll();
            inicializarLabelSinFunciones();
            RellenarFunciones();
        }

        private void inicializarLabelSinFunciones()
        {
            labelSinFunciones = new Label();
            labelSinFunciones.Dock = DockStyle.Fill;
            labelSinFunciones.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinFunciones.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinFunciones.Text = "No se encontraron funciones disponibles actualmente :(";
            labelSinFunciones.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelFunciones, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void RellenarFunciones()
        {
            List<Funcion> listaFuncionesActivas = PropiedadesGenerales.FuncionesController.ListarFuncionesActivas();
            listaControles = new List<Control>();
            foreach (Funcion funcion in listaFuncionesActivas)
            {
                Elem_funcion elemento = new Elem_funcion(funcion);
                panelFunciones.Controls.Add(elemento);
                elemento.Dock = DockStyle.Top;
                listaControles.Add(elemento);
            }
        }

        private void BtnBuscarFuncion_Click(object sender, EventArgs e)
        {
            FiltroFunciones();
        }

        private void key_release(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                FiltroFunciones();
            }
        }

        private void FiltroFunciones()
        {
            panelFunciones.Controls.Clear();
            if (string.IsNullOrEmpty(txtBuscarFuncion.Text))
            {
                foreach (Control item in listaControles)
                {
                    panelFunciones.Controls.Add(item);
                }
            }
            else
            {
                foreach (Control item in listaControles)
                {
                    if (((Elem_funcion)item).CFuncionesController.Pelicula.pelicula_titulo.Contains(txtBuscarFuncion.Text.ToUpper()) ||
                        ((Elem_funcion)item).CFuncionesController.Pelicula.pelicula_titulo_original.Contains(txtBuscarFuncion.Text.ToUpper()))
                    {
                        panelFunciones.Controls.Add(item);
                    }
                }
            }
            if (panelFunciones.Controls.Count == 0)
            {
                panelFunciones.Controls.Add(labelSinFunciones);
            }
        }
    }
}
