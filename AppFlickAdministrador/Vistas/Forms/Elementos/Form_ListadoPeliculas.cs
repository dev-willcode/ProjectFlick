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
            DisenoTabla();
            MostrarPeliculas();
            this.CenterToParent();
        }

        private void DisenoTabla()
        {
            tablaPeliculas.AutoResizeColumns();
            tablaPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablaPeliculas.BackgroundColor = Color.FromArgb(45, 45, 45);
            tablaPeliculas.ForeColor = Color.White;
            tablaPeliculas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 109, 237);
            tablaPeliculas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaPeliculas.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            tablaPeliculas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tablaPeliculas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaPeliculas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }
        private void MostrarPeliculas()
        {
            tablaPeliculas.DataSource = PropiedadesGenerales.PeliculaPController.ListarPeliculas();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string idTitulo = tablaPeliculas.CurrentRow.Cells[0].Value.ToString();
            string titulo = tablaPeliculas.CurrentRow.Cells[1].Value.ToString();
            Form_Funciones form = (Form_Funciones)Application.OpenForms["Form_Funciones"];
            form.txtidPelícula.Text = idTitulo;
            form.txtTituloP.Text = titulo;
            Close();
        }
    }
}
