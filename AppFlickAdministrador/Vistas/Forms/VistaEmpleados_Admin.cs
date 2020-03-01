using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using AppFlickAdministrador.Vistas.Init;
using Controllers;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms
{
    public partial class VistaEmpleados_Admin : Vistas
    {
        private PanelScrollHelper scroll;
        private List<Elem_Empleado> listaControles;
        private Label labelSinEmpleados;

        public VistaEmpleados_Admin() { }

        public VistaEmpleados_Admin(Dashboard dashboard)
            : base(dashboard)
        {
            InitializeComponent();
            PropiedadesScroll();
            InicializarLabelSinFunciones();
            RellenarEmpleados();
        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelContenedor, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void InicializarLabelSinFunciones()
        {
            labelSinEmpleados = new Label();
            labelSinEmpleados.Visible = false;
            labelSinEmpleados.Dock = DockStyle.Fill;
            labelSinEmpleados.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinEmpleados.ForeColor = Color.FromArgb(69, 69, 69);
            labelSinEmpleados.Text = "No se encontraron empleados, que esperas para comprar tus boletos!";
            labelSinEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            panelContenedor.Controls.Add(labelSinEmpleados);
        }

        public void RellenarEmpleados()
        {
            try
            {
                panelContenedor.Controls.Clear();
                List<Empleado> lista = PropiedadesGenerales.EmpleadoController.ListarEmpleados();
                listaControles = new List<Elem_Empleado>();
                lista.ForEach(cliente =>
                {
                    Elem_Empleado elemento = new Elem_Empleado(this,cliente);
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
        private void EventoOcultar(object sender, EventArgs e)
        {
            int conteoVisibles = 0;
            listaControles.ForEach(elemento => { if (elemento.Visible) { conteoVisibles++; } });
            if (conteoVisibles == 0)
            {
                labelSinEmpleados.Visible = true;
            }
            else
            {
                labelSinEmpleados.Visible = false;
            }
        }

        private void FiltroFunciones()
        {
            if (string.IsNullOrEmpty(txtBuscarFactura.Text))
            {
                listaControles.ForEach(elemento => elemento.Visible = true);
            }
            else
            {
                foreach (Elem_Empleado elemento in listaControles)
                {
                    if (!(elemento.empleado.empleado_nombres.Contains(txtBuscarFactura.Text) ||
                        elemento.empleado.empleado_apellidos.Contains(txtBuscarFactura.Text) ||
                        elemento.empleado.empleado_cedula.Contains(txtBuscarFactura.Text)))
                    {
                        elemento.Visible = false;
                    }
                }
            }
        }
        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            FiltroFunciones();
        }

        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            FiltroFunciones();
        }

        private void txtBuscarFactura_Enter(object sender, EventArgs e)
        {
            txtBuscarFactura.Text = "";
        }

        private void txtBuscarFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                FiltroFunciones();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form_Empleado form = new Form_Empleado(this, "Ingresar Empleado");
            form.ShowDialog();
        }
    }
}
