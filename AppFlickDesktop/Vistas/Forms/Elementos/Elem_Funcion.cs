using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms;
using AppFlickDesktop.Vistas.Forms.Elementos;
using Controllers.Controller;
using Entity.Entidades;

namespace AppFlickDesktop.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        internal CustomFuncionesController CFuncionesController { get; set; }

        public Elem_funcion()
        {
            InitializeComponent();
        }

        public Elem_funcion(Funcion funciones)
        {
            CFuncionesController = new CustomFuncionesController(funciones);
            InitializeComponent();
            rellenarDatos();
        }

        private void rellenarDatos()
        {
            var_titulo.Text = CFuncionesController.Pelicula.pelicula_titulo;
            var_titulo_original.Text = CFuncionesController.Pelicula.pelicula_titulo_original;
            var_censura.Text = "Censura: " + CFuncionesController.Pelicula.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + CFuncionesController.Pelicula.pelicula_duracion;
            var_categoria.Text = "Categoria: " + CFuncionesController.ObtenerCategorias();
            rellenarIdioma();
        }

        private void rellenarIdioma()
        {
            Elem_idioma_funcion elem = new Elem_idioma_funcion(CFuncionesController.Idioma);
            container_idiomas.Controls.Add(elem);
            elem.Dock = DockStyle.Fill;
        }

        internal void btnTrailer_Click(object sender, EventArgs e)
        {
            Form_Trailer form_Trailer = new Form_Trailer(CFuncionesController);
            form_Trailer.ShowDialog();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Form_Detalle form_detalle = new Form_Detalle(CFuncionesController);
            form_detalle.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Form_Comprar form = new Form_Comprar(CFuncionesController);
            form.ShowDialog();
        }
    }
}
