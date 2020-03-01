using AppFlickAdministrador.Utils;
using Controllers;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Clientes : Form
    {
        private readonly Cliente ClienteActual;
        private VistaClientes_Admin VistaClientes_Admin { get; set; }
        public string Accion { get; set; }

        public Form_Clientes(VistaClientes_Admin vistaClientes_Admin, string titulo)
        {
            Accion = Constantes.accionInsertar;
            inicializarformulario(vistaClientes_Admin, titulo);
        }

        public Form_Clientes(VistaClientes_Admin vistaClientes_Admin_Admin,
            string titulo, Cliente cliete)
        {
            Accion = Constantes.accionEditar;
            ClienteActual = cliete;
            inicializarformulario(vistaClientes_Admin_Admin, titulo);
        }

        private void inicializarformulario(VistaClientes_Admin vistaClientes_Admin_Admin, string titulo)
        {
            VistaClientes_Admin = vistaClientes_Admin_Admin;
            Text = titulo;
            InitializeComponent();
            this.CenterToParent();
            if (Accion.Equals(Constantes.accionEditar))
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            txtCedula.Text = ClienteActual.cliente_cedula.ToString();
            txtNombre.Text = ClienteActual.cliente_nombres.ToString();
            txtApellido.Text = ClienteActual.cliente_apellidos.ToString();
            txtTelefono.Text = ClienteActual.cliente_telefono.ToString();
            txtEmail.Text = ClienteActual.cliente_email.ToString();
            txtDireccion.Text = ClienteActual.cliente_direccion.ToString();
            //txtUsuario.Text;
            //txtContraseña;
        }

        private bool ValidarCamposCliente()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                errores += " - Escriba la cedula" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errores += " - Escriba el nombre" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errores += " - Escriba el apellido" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errores += " - Escriba el telefono" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errores += " - Escriba el email" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errores += " - Escriba la direccion" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errores += " - Escriba un Usuario" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                errores += " - Escriba una Contraseña" + Environment.NewLine;
            }
            return string.IsNullOrEmpty(errores);
        }

        private void NuevoCliente()
        {
            if (ValidarCamposCliente())
            {
                try
                {
                    Usuario usuario = new Usuario();
                    usuario.usuario_username = txtUsuario.Text;
                    usuario.usuario_password = txtContraseña.Text;

                    if (!PropiedadesGenerales.UsuarioController.UsuarioEstaRepetido(usuario))
                    {
                        Cliente cliente = new Cliente();
                        cliente.cliente_cedula = txtCedula.Text;
                        cliente.cliente_apellidos = txtApellido.Text;
                        cliente.cliente_nombres = txtNombre.Text;
                        cliente.cliente_telefono = txtTelefono.Text;
                        cliente.cliente_email = txtEmail.Text;
                        cliente.cliente_direccion = txtDireccion.Text;
                        cliente.id = PropiedadesGenerales.UsuarioController.RegistrarNuevoCliente(usuario, cliente);
                        if (cliente.id != -1)
                        {
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Cliente registrado correctamente");
                            VistaClientes_Admin.RellenarClientes();
                            Close();
                        }
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al registrarse", "el usuario está repetido!");
                    }
                }
                catch (ControllerException ex)
                {

                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar cliente", "Ingrese bien los datos");
            }
        }

        private void EditarCliente()
        {
            if (ValidarCamposCliente())
            {
                Cliente clienteTemp = generarCliente();
                if (!clienteTemp.Equals(PropiedadesGenerales.EmpleadoActual))
                {
                    try
                    {
                        if (PropiedadesGenerales.ClienteController.Update(clienteTemp))
                        {
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Cliente actualizado");
                            VistaClientes_Admin.RellenarClientes();                            
                            Close();
                        }
                        else
                        {
                            PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                                "Error al actualizar el cliente");
                        }
                    }
                    catch (ControllerException ex)
                    {
                        PropiedadesGenerales.Notificar.notificarError(ex);
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar", "No cambio ningun dato!");
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar cliente", "Ingrese bien los datos");
            }
        }


        private Cliente generarCliente()
        {
            Cliente cliente = new Cliente()
            {
                id = ClienteActual.id,
                cliente_usuario = ClienteActual.cliente_usuario,
                cliente_cedula = txtCedula.Text,
                cliente_apellidos = txtApellido.Text,
                cliente_nombres = txtNombre.Text,
                cliente_telefono = txtTelefono.Text,
                cliente_email = txtEmail.Text,
                cliente_direccion = txtDireccion.Text,
                cliente_imagen = ClienteActual.cliente_imagen
        };
            return cliente;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(Constantes.accionInsertar))
            {
                NuevoCliente();
            }
            else
            {
                EditarCliente();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

