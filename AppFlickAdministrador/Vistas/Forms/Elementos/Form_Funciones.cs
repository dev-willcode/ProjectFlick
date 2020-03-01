using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Funciones : Form
    {
        public Form_Funciones()
        {
            InitializeComponent();
        }

        private void txtPelícula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
