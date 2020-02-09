using System;
using System.Windows.Forms;
using Controllers.Controller;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Form_Detalle : Form
    {
        CustomFuncionesController CFuncionesController { get; set; }

        public Form_Detalle(CustomFuncionesController cFuncionesController)
        {
            InitializeComponent();
            CFuncionesController = cFuncionesController;
            rellenarDatos();
        }
        private void rellenarDatos()
        {
            var_titulo.Text = CFuncionesController.Pelicula.pelicula_titulo;
            var_titulo_original.Text = CFuncionesController.Pelicula.pelicula_titulo_original;
            var_censura.Text = "Censura: " + CFuncionesController.Pelicula.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + CFuncionesController.Pelicula.pelicula_duracion;
            var_categoria.Text = "Categoria: " + CFuncionesController.ObtenerCategorias();
            var_sinopsis.Text = "Directores: " + CFuncionesController.Pelicula.pelicula_sinopsis;
            var_directores.Text = "Directores: " + CFuncionesController.Pelicula.pelicula_director;
            var_reparto.Text = "Reparto: " + CFuncionesController.Pelicula.pelicula_reparto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
