using Entity.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_ListadoCategoria : Form
    {
        private Form_Pelicula Form_Pelicula { get; set; }
        public Form_ListadoCategoria(Form_Pelicula form_Pelicula)
        {
            InitializeComponent();
            DisenoTabla();
            MostrarCategorias();
            this.CenterToParent();
            Form_Pelicula = form_Pelicula;
        }

        private void DisenoTabla()
        {
            tablaCategoria2.AutoResizeColumns();
            tablaCategoria2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablaCategoria2.BackgroundColor = Color.FromArgb(45, 45, 45);
            tablaCategoria2.ForeColor = Color.White;
            tablaCategoria2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 109, 237);
            tablaCategoria2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaCategoria2.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            tablaCategoria2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tablaCategoria2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaCategoria2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void MostrarCategorias()
        {
            tablaCategoria2.DataSource = PropiedadesGenerales.CategoriaController.ListarCategorias();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (tablaCategoria2.CurrentRow != null) //selecciono una fila
            {
                bool estaRepetido = false;
                Categoria categoriaSeleccionada = (Categoria)tablaCategoria2.CurrentRow.DataBoundItem;
                foreach (Categoria item in Form_Pelicula.categoriaSource)
                {
                    if (item.id == categoriaSeleccionada.id)
                    {
                        estaRepetido = true;
                    }
                }
                if (estaRepetido)
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Error", "La categoria esta repetida");
                }
                else
                {
                    Form_Pelicula.AnadirCategoria(categoriaSeleccionada);
                }

            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error", "No se ha seleccionado una fila");
            }
        }
    }
}
