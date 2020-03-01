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
    public partial class Form_ListadoPeliculas : Form
    {
        public Form_ListadoPeliculas()
        {
            InitializeComponent();
            MostrarPeliculas();
            this.CenterToParent();
        }

        private void MostrarPeliculas()
        {          
            tablaPeliculas.DataSource = PropiedadesGenerales.PeliculaPController.ListarPeliculas();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string titulo = tablaPeliculas.CurrentRow.Cells[0].Value.ToString();
            Form_Funciones form = (Form_Funciones)Application.OpenForms["Form_Funciones"];
            form.txtPelícula.Text = titulo;
            Close();
        }
    }
}
