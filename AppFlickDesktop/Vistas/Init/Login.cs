using System;
using System.Drawing;
using System.Windows.Forms;
using AppFlickCliente.Vistas.Init;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickCliente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handle = base.CreateParams;
                handle.ExStyle |= 0x02000000;
                return handle;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario_username = txtUsername.Text;
            usuario.usuario_password = txtPassword.Text;

            if (validarCamposLogin())
            {
                try
                {
                    Cliente cliente = PropiedadesGenerales.UsuarioController.IniciarSesion(usuario);
                    if (cliente != null)
                    {
                        abrirDashboard(cliente);
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al iniciar sesión",
                            "No se consiguió iniciar la sesión, usuario o contraseña incorrectos.");
                    }
                }
                catch (ControllerException ex)
                {

                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al iniciar sesión",
                    "verifique que ha llenado los campos de usuario y contraseña!");
            }
        }

        private void abrirDashboard(Cliente cliente)
        {
            PropiedadesGenerales.ClienteActual = cliente;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private bool validarCamposLogin()
        {
            return !(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            movible.Location = new Point(0, 450);
        }

        private void efecto_logo(object sender, EventArgs e)
        {
            efecto.HideSync(logoImagen);
            efecto.ShowSync(logoImagen);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarCamposRegistro())
            {
                Usuario usuario = new Usuario();
                usuario.usuario_username = txtnUsuario.Text;
                usuario.usuario_password = txtnContrasena.Text;

                if (!PropiedadesGenerales.UsuarioController.UsuarioEstaRepetido(usuario))
                {
                    Cliente cliente = new Cliente();
                    cliente.cliente_cedula = txtnCedula.Text;
                    cliente.cliente_apellidos = txtnApellidos.Text;
                    cliente.cliente_nombres = txtnNombres.Text;
                    cliente.cliente_telefono = txtnTelefono.Text;
                    cliente.cliente_email = txtnEmail.Text;
                    cliente.cliente_direccion = txtnDireccion.Text;

                    if (PropiedadesGenerales.UsuarioController.RegistrarNuevoCliente(usuario, cliente))
                    {
                        PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "registro correcto");
                        abrirDashboard(cliente);
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Error al registrarse", "el usuario está repetido!");
                }
            }
        }

        private bool validarCamposRegistro()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txtnUsuario.Text))
            {
                errores += " - Inserte un nombre de usuario" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnContrasena.Text))
            {
                errores += " - Inserte una contraseña" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnApellidos.Text))
            {
                errores += " - Inserte un apellido" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnNombres.Text))
            {
                errores += " - Inserte un nombre" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnCedula.Text))
            {
                errores += " - Inserte una cédula" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnTelefono.Text))
            {
                errores += " - Inserte un telefono de contacto" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnEmail.Text))
            {
                errores += " - Inserte un email" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtnDireccion.Text))
            {
                errores += " - Inserte una direccion" + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(errores))
            {
                PropiedadesGenerales.Notificar.notificarFallo("Revise el formulario",
                    "revise los siguientes errores: " + Environment.NewLine + errores);
            }

            return string.IsNullOrEmpty(errores);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (movible.Location.Y > 0)
            {
                movible.Location = new Point(movible.Location.X, movible.Location.Y - 5);
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
