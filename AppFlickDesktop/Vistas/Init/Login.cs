using System;
using System.Drawing;
using System.Windows.Forms;
using AnimateForms.Core;
using AppFlickDesktop.Vistas.Init;
using AppFlickDesktop.Vistas.Notificaciones;
using FlickLib.Entidades;
using FlickLib.Funcionalidades;

namespace AppFlickDesktop
{
    public partial class Login : Form
    {
        private FuncLogin funcLogin = new FuncLogin();
        private readonly Animate animate = new Animate();
        private Notificar notificar = new Notificar();
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

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            await animate.Move(movible, Easings.Linear, 1200, new Point(0, 0));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario_username = txtUsername.Text;
            usuario.usuario_password = txtPassword.Text;

            if (validarCamposLogin())
            {
                Cliente cliente = funcLogin.IniciarSesionCliente(usuario);
                if (cliente != null)
                    abrirDashboard(cliente);
                else
                    notificar.notificarFallo("Error al iniciar sesión",
                        "No se consiguió iniciar la sesión, usuario o contraseña incorrectos.");
            }
            else
                notificar.notificarFallo("Error al iniciar sesión",
                    "verifique que ha llenado los campos de usuario y contraseña!");
        }

        private void abrirDashboard(Cliente cliente)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.asignarUsuario(cliente);
            dashboard.Show();
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

                if (!funcLogin.UsuarioEstaRepetido(usuario))
                {
                    Cliente cliente = new Cliente();
                    cliente.cliente_cedula = txtnCedula.Text;
                    cliente.cliente_apellidos = txtnApellidos.Text;
                    cliente.cliente_nombres = txtnNombres.Text;
                    cliente.cliente_telefono = txtnTelefono.Text;
                    cliente.cliente_email = txtnEmail.Text;
                    cliente.cliente_direccion = txtnDireccion.Text;

                    if (funcLogin.RegistrarCliente(usuario, cliente))
                    {
                        notificar.notificarCorrecto("Completado", "registro correcto");
                        abrirDashboard(cliente);
                    }
                }
                else
                {
                    notificar.notificarFallo("Error al registrarse", "el usuario está repetido!");
                }
            }
        }

        private bool validarCamposRegistro()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txtnUsuario.Text)) errores += " - Inserte un nombre de usuario" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnContrasena.Text)) errores += " - Inserte una contraseña" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnApellidos.Text)) errores += " - Inserte un apellido" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnNombres.Text)) errores += " - Inserte un nombre" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnCedula.Text)) errores += " - Inserte una cédula" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnTelefono.Text)) errores += " - Inserte un telefono de contacto" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnEmail.Text)) errores += " - Inserte un email" + Environment.NewLine;
            if (string.IsNullOrEmpty(txtnDireccion.Text)) errores += " - Inserte una direccion" + Environment.NewLine;

            if (!string.IsNullOrEmpty(errores))
                notificar.notificarFallo("Revise el formulario", 
                    "revise los siguientes errores: " + Environment.NewLine + errores);
            return string.IsNullOrEmpty(errores);
        }
    }
}
