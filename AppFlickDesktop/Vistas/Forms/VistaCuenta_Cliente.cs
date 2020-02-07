using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms.Elementos;
using AppFlickDesktop.Vistas.Notificaciones;
using Controllers.Controller;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaCuenta_Cliente : UserControl
    {
        private PanelScrollHelper scroll;

        public VistaCuenta_Cliente()
        {
            InitializeComponent();
            propiedadesScroll();
            rellenarTarjetas();
            cargarDatos();
        }

        private void cargarDatos()
        {
            txtCedula_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_cedula.ToString();
            txtApellidos_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_apellidos.ToString();
            txtNombres_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_nombres.ToString();
            txtTelefono_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_telefono.ToString();
            txtEmail_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_email.ToString();
            txtDireccion_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_direccion.ToString();

        }

        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelPrincipal, scrollBar, true);
            scroll.UpdateScrollBar();
        }
        public void rellenarTarjetas()
        {
            List<Tarjetas> listaTarjeta = PropiedadesGenerales.TarjetasController
                .listarTarjetas(PropiedadesGenerales.ClienteActual.id);
            for (int i = 0; i < listaTarjeta.Count; i++)
            {
                Elem_tarjeta elemento = new Elem_tarjeta(listaTarjeta[i]);
                panelPrincipal.Controls.Add(elemento);
                elemento.Dock = DockStyle.Left;
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            Cliente clienteTemp = generarCliente();
            if (!clienteTemp.Equals(PropiedadesGenerales.ClienteActual))
            {
                if (PropiedadesGenerales.ClienteController.Update(clienteTemp))
                {
                    PropiedadesGenerales.Notificar.notificarCorrecto("Actualizado",
                        "Informacion personal actualizada correctamente");
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                        "Error al actualizar su informacion personal");
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
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
            cliente.id = PropiedadesGenerales.ClienteActual.id;
            return cliente;

        }

        private void btnMasTarjetas_Click(object sender, EventArgs e)
        {
            Form_Tarjeta form = new Form_Tarjeta(this);
            form.ShowDialog();
        }
    }
}
