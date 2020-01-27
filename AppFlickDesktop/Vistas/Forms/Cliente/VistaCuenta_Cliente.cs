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
using FlickLib.DAO;
using AppFlickDesktop.Vistas.Init;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class VistaCuenta_Cliente : UserControl
    {
        PanelScrollHelper scroll;
        private FlickLib.Entidades.Cliente cliente;
        private ClienteDAO daoClientes = new ClienteDAO();



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
            FlickLib.Entidades.Cliente clienteTemp = generarCliente();
            if (!clienteTemp.Equals(cliente))
            {
                if (daoClientes.Update(clienteTemp))
                    Dashboard.Notificar.notificarCorrecto("Actualizado", 
                        "Informacion personal actualizada correctamente");
                else
                    Dashboard.Notificar.notificarCorrecto("No se consiguio actualizar", 
                        "Error al actualizar su informacion personal");
            }
        }

        private FlickLib.Entidades.Cliente generarCliente()
        {
            FlickLib.Entidades.Cliente cliente = new FlickLib.Entidades.Cliente();
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
