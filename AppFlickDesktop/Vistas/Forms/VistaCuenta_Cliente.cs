using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Notificaciones;
using Entity.Entidades;
using Controllers.DTO;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaCuenta_Cliente : UserControl
    {
        private ClienteDTO clienteDTO = Utils.PropiedadesGenerales.ClienteDTO;
        private Notificar Notificar = Utils.PropiedadesGenerales.Notificar;
        private PanelScrollHelper scroll;
        private Cliente cliente;

        public VistaCuenta_Cliente(Cliente cliente)
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
            Cliente clienteTemp = generarCliente();
            if (!clienteTemp.Equals(cliente))
            {
                if (clienteDTO.ActualizarCliente(clienteTemp))
                {
                    Notificar.notificarCorrecto("Actualizado",
                        "Informacion personal actualizada correctamente");
                }
                else
                {
                    Notificar.notificarFallo("No se consiguio actualizar",
                        "Error al actualizar su informacion personal");
                }
            } else
            {
                Notificar.notificarFallo("No se consiguio actualizar",
                        "No cambio ningun dato!");
            }
        }

        private Cliente generarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.cliente_cedula = txtCedula_usuario.Text;
            cliente.cliente_nombres = txtNombres_usuario.Text;
            cliente.cliente_apellidos = txtApellidos_usuario.Text;
            cliente.cliente_email = txtEmail_usuario.Text;
            cliente.cliente_direccion = txtDireccion_usuario.Text;
            cliente.cliente_telefono = txtTelefono_usuario.Text;
            cliente.id = this.cliente.id;
            return cliente;

        }
    }
}
