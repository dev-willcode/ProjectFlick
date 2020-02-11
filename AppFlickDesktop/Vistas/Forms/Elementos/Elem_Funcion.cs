using System;
using System.Windows.Forms;
using AppFlickCliente.Vistas.Forms;
using AppFlickCliente.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickCliente.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        public readonly VistaFunciones funcion;

        public Elem_funcion() { }

        public Elem_funcion(VistaFunciones funcion)
        {
            InitializeComponent();
            rellenarDatos(funcion);
            this.funcion = funcion;
        }

        private void rellenarDatos(VistaFunciones funcion)
        {
            try
            {
                var_titulo.Text = funcion.pelicula_titulo;
                var_titulo_original.Text = funcion.pelicula_titulo_original;
                var_censura.Text = "Censura: " + funcion.pelicula_tipo_censura;
                var_duracion_pelicula.Text = "Duración: " + funcion.pelicula_duracion;
                var_categoria.Text = funcion.categorias = "Categoria: " + PropiedadesGenerales
                    .CategoriaController.ListarCategoriasString(funcion.funcion_pelicula);
                rellenarIdioma(funcion.idioma_abreviatura);
                if (funcion.pelicula_imagen != null)
                {
                    var_imagen_pelicula.Image = Utils.UtilsProcedimientos.generarImagen(funcion.pelicula_imagen);
                }
            }
            catch (ControllerException ex)
            {

                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void rellenarIdioma(string idioma_abreviatura)
        {
            Elem_idioma_funcion elem = new Elem_idioma_funcion(idioma_abreviatura);
            container_idiomas.Controls.Add(elem);
            elem.Dock = DockStyle.Fill;
        }

        internal void btnTrailer_Click(object sender, EventArgs e)
        {
            Form_Trailer form_Trailer = new Form_Trailer(funcion);
            form_Trailer.ShowDialog();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Form_Detalle form_detalle = new Form_Detalle(funcion);
            form_detalle.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Form_Comprar form = new Form_Comprar(funcion);
            form.ShowDialog();
        }
    }
}
