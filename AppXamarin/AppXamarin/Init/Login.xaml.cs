using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamarin.Utils;
using Controllers;
using Entity.Entidades;
using Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Init
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void MaterialButton_Clicked(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario_username = txtUser.Text;
            usuario.usuario_password = txtPassword.Text;

            if (validarCamposLogin())
            {
                try
                {
                    Cliente cliente = PropiedadesGenerales.UsuarioController.IniciarSesionCliente(usuario);
                    if (cliente != null)
                    {
                        abrirInicio(cliente);
                    }
                    else
                    {
                        await UtilsNotificaciones.NotificarError(this, "Error al iniciar sesión",
                            "No se consiguió iniciar la sesión, usuario o contraseña incorrectos.");
                    }
                }
                catch (ControllerException ex)
                {

                    await UtilsNotificaciones.NotificarFallo(this,ex);
                }
            }
            else
            {
                await UtilsNotificaciones.NotificarError(this, "Error al iniciar sesión",
                    "verifique que ha llenado los campos de usuario y contraseña!");
            }
        }

        private void abrirInicio(Cliente cliente)
        {
            PropiedadesGenerales.ClienteActual = new Models.VistaClienteModel(cliente);
            Navigation.PushModalAsync(new MainPage());
        }

        private bool validarCamposLogin()
        {
            return !(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text));
        }
    }
}