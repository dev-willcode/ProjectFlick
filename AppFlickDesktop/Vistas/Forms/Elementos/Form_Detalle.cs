using System;
using System.Windows.Forms;
using Entity.Entidades.EntidadesPersonalizadas;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Form_Detalle : Form
    {
        private readonly VistaFunciones funcion;

        public Form_Detalle(VistaFunciones funcion)
        {
            this.funcion = funcion;
            InitializeComponent();
            rellenarDatos();
        }

        private void rellenarDatos()
        {
            var_titulo.Text = funcion.pelicula_titulo;
            var_titulo_original.Text = funcion.pelicula_titulo_original;
            var_censura.Text = "Censura: " + funcion.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + funcion.pelicula_duracion;
            var_categoria.Text = "Categoria: " + funcion.categorias;
            var_sinopsis.Text = "Sinopsis: " + funcion.pelicula_sinopsis;
            var_directores.Text = "Directores: " + funcion.pelicula_director;
            var_reparto.Text = "Reparto: " + funcion.pelicula_reparto;
            if (funcion.pelicula_imagen != null)
            {
                var_imagen_pelicula.Image = Utils.UtilsProcedimientos.generarImagen(funcion.pelicula_imagen);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
