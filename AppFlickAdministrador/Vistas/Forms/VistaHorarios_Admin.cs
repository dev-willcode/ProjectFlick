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
    public partial class VistaHorarios_Admin : Vistas
    {
        private PanelScrollHelper scroll;
        private List<Elem_Horario> listaControles;
        private Label labelSinHorario;

        public VistaHorarios_Admin() { }

        public VistaHorarios_Admin(Dashboard dashboard)
            : base(dashboard)
        {
            InitializeComponent();
            PropiedadesScroll();
            InicializarLabelSinFunciones();
            RellenarHorarios();
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelHorarios, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void InicializarLabelSinFunciones()
        {
            labelSinHorario = new Label();
            labelSinHorario.Visible = false;
            labelSinHorario.Dock = DockStyle.Fill;
            labelSinHorario.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinHorario.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinHorario.Text = "No se encontraron horarios!";
            labelSinHorario.TextAlign = ContentAlignment.MiddleCenter;
            panelHorarios.Controls.Add(labelSinHorario);
        }

        private void RellenarHorarios()
        {
            try
            {
                List<Horarios> lista = PropiedadesGenerales.HorarioController
                    .ListarHorarios();
                listaControles = new List<Elem_Horario>();
                lista.ForEach(horario =>
                {
                    Elem_Horario elemento = new Elem_Horario(horario);
                    panelHorarios.Controls.Add(elemento);
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
                labelSinHorario.Visible = true;
            }
            else
            {
                labelSinHorario.Visible = false;
            }
        }
    }
}
