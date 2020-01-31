using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Init;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class Form_Detalle : Form
    {
        private Elem_funcion elem_funcion;

        public Form_Detalle(Elem_funcion elem_funcion)
        {
            InitializeComponent();
            this.elem_funcion = elem_funcion;
            rellenarDatos();
        }
        private void rellenarDatos()
        {
            var_titulo.Text = elem_funcion.Funcion.pelicula_titulo;
            var_titulo_original.Text = elem_funcion.Funcion.pelicula_titulo_original;
            var_censura.Text = "Censura: " + elem_funcion.Funcion.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + elem_funcion.Funcion.pelicula_duracion;
            var_categoria.Text = "Categoria: " + elem_funcion.obtenerCategorias();
            var_sinopsis.Text = "Directores: " + elem_funcion.Funcion.pelicula_sinopsis;
            var_directores.Text = "Directores: " + elem_funcion.Funcion.pelicula_director;
            var_reparto.Text = "Reparto: " + elem_funcion.Funcion.pelicula_reparto;
            btnTrailer.Click += new EventHandler(elem_funcion.btnTrailer_Click);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
