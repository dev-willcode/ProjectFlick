using System;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Init;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validarCamposLogin())
            {
                Usuario usuario = new Usuario();
                usuario.usuario_username = txtUsername.Text;
                usuario.usuario_password = txtPassword.Text;
                try
                {
                    Empleado empleado = PropiedadesGenerales.UsuarioController.IniciarSesionEmpleado(usuario);
                    if (empleado != null)
                    {
                        abrirDashboard(empleado);
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

        private void abrirDashboard(Empleado empleado)
        {
            PropiedadesGenerales.EmpleadoActual = empleado;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private bool validarCamposLogin()
        {
            return !(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text));
        }

        private void efecto_logo(object sender, EventArgs e)
        {
            efecto.HideSync(logoImagen);
            efecto.ShowSync(logoImagen);
        }
    }
}
