using System;
using System.Drawing;
using System.Windows.Forms;
using AnimateForms.Core;
using AppFlickDesktop.Vistas.Init;

namespace AppFlickDesktop
{
    public partial class Login : Form
    {
        private readonly Animate animate = new Animate();
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
            Dashboard dashboard = new Dashboard();            
            dashboard.Show();
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
    }
}
