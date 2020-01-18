using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class VistaCuenta_Cliente : UserControl
    {
        PanelScrollHelper scroll;
        private FlickLib.Entidades.Cliente cliente;



        public VistaCuenta_Cliente(FlickLib.Entidades.Cliente cliente)
        {
            InitializeComponent();
            propiedadesScroll();
            rellenarTarjetas();
            this.cliente = cliente;
            cargarDatos();
        }

        private void cargarDatos()
        {
            txtCedula_usuario.Text = cliente.cliente_cedula.ToString();
            txtApellidos_usuario.Text = cliente.cliente_apellidos.ToString();
            txtNombres_usuario.Text = cliente.cliente_nombres.ToString();
            txtTelefono_usuario.Text = cliente.cliente_telefono.ToString();
            txtEmail_usuario.Text = cliente.cliente_email.ToString();
            txtDireccion_usuario.Text = cliente.cliente_direccion.ToString();

        }

        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelPrincipal, scrollBar, true);
            scroll.UpdateScrollBar();
        }
        private void rellenarTarjetas()
        {
            for (int i = 0; i < 2; i++)
            {
                Elem_tarjeta elemento = new Elem_tarjeta();
                panelPrincipal.Controls.Add(elemento);
                elemento.Dock = DockStyle.Left;
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            // actualizar here
        }
    }
}
