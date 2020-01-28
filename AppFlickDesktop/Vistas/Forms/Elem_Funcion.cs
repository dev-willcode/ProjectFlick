using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Forms;
using Entity.Entidades.Vistas;

namespace AppFlickDesktop.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        internal FuncionesActivas Funcion;

        public Elem_funcion()
        {
            InitializeComponent();
        }

        public Elem_funcion(FuncionesActivas funcionesActivas)
        {
            InitializeComponent();
            Funcion = funcionesActivas;
            rellenarDatos();
        }

        private void rellenarDatos()
        {
            var_titulo.Text = Funcion.pelicula_titulo;
            var_titulo_original.Text = Funcion.pelicula_titulo_original;
            var_censura.Text = "Censura: " + Funcion.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + Funcion.pelicula_duracion;
            var_categoria.Text = "Categoria: " + obtenerCategorias();
            rellenarIdiomas();
            ;
        }

        private void rellenarIdiomas()
        {
            foreach (string idioma in Funcion.idioma_abreviatura)
            {
                Elem_idioma_funcion elem = new Elem_idioma_funcion(idioma);
                container_idiomas.Controls.Add(elem);
                elem.Dock = DockStyle.Fill;
            }
        }

        internal string obtenerCategorias()
        {
            string resultado = "";
            foreach (string categoria in Funcion.nombre_categoria)
            {
                resultado += categoria + ", ";
            }
            return resultado.Substring(0, resultado.Length - 2);
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
    }
}
