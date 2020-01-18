using System.Diagnostics;
using System.Windows.Forms;
using FlickLib.Entidades.Vistas;

namespace AppFlickDesktop.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        private FuncionesActivas Funcion;

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
            btnTrailer.Click += new System.EventHandler((o, arg) =>
                Process.Start(Funcion.pelicula_url_trailer)
            );
        }
    }
}
