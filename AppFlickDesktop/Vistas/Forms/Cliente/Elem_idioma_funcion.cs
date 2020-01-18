using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class Elem_idioma_funcion : UserControl
    {
        public Elem_idioma_funcion(string idioma)
        {
            InitializeComponent();
            var_idioma.Text = idioma;
        }
    }
}
