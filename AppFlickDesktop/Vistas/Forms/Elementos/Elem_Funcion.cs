using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms;
using AppFlickDesktop.Vistas.Forms.Elementos;
using Controllers.Controller;
using Entity.Entidades;

namespace AppFlickDesktop.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        private PeliculaController peliculaController = Utils.PropiedadesGenerales.PeliculaController;
        private CategoriaController categoriaController = Utils.PropiedadesGenerales.CategoriaController;
        private IdiomaController idiomaController = Utils.PropiedadesGenerales.IdiomaController;

        internal Funcion Funcion { get; set; }
        internal Pelicula Pelicula { get; set; }
        internal Idioma Idioma { get; set; }

        public Elem_funcion()
        {
            InitializeComponent();
        }

        public Elem_funcion(Funcion funciones)
        {
            InitializeComponent();
            Funcion = funciones;
            rellenarDatos();
        }

        private void rellenarDatos()
        {
            Pelicula = peliculaController.Get(Funcion.funcion_pelicula);
            var_titulo.Text = Pelicula.pelicula_titulo;
            var_titulo_original.Text = Pelicula.pelicula_titulo_original;
            var_censura.Text = "Censura: " + Pelicula.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + Pelicula.pelicula_duracion;
            var_categoria.Text = "Categoria: " + obtenerCategorias();
            rellenarIdioma();
        }

        private void rellenarIdioma()
        {
            Idioma = idiomaController.Get(Funcion.funcion_idioma);
            Elem_idioma_funcion elem = new Elem_idioma_funcion(Idioma);
            container_idiomas.Controls.Add(elem);
            elem.Dock = DockStyle.Fill;
        }

        internal string obtenerCategorias()
        {
            String resul = "";
            List<Categoria> listaCategorias = categoriaController.ListarCategorias(Pelicula.id);
            foreach (Categoria item in listaCategorias)
            {
                resul += item.categoria_nombre + ", ";
            }
            return resul.Substring(0, resul.Length - 2);
        }

        internal void btnTrailer_Click(object sender, EventArgs e)
        {
            Form_Trailer form_Trailer = new Form_Trailer(this);
            form_Trailer.ShowDialog();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Form_Detalle form_detalle = new Form_Detalle(this);
            form_detalle.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Form_Comprar form = new Form_Comprar(this);
            form.ShowDialog();
        }
    }
}
