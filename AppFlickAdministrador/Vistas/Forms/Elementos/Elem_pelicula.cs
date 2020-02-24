using System.Windows.Forms;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_pelicula : UserControl
    {
        public readonly Pelicula Pelicula;

        public Elem_pelicula() { }

        public Elem_pelicula(Pelicula pelicula)
        {
            InitializeComponent();
            rellenarDatos(pelicula);
            this.Pelicula = pelicula;
        }

        private void rellenarDatos(Pelicula pelicula)
        {
            try
            {
                var_titulo.Text = pelicula.pelicula_titulo;
                var_titulo_original.Text = pelicula.pelicula_titulo_original;
                var_censura.Text = "Censura: " + pelicula.pelicula_tipo_censura;
                var_duracion_pelicula.Text = "Duración: " + pelicula.pelicula_duracion;
                var_directores.Text = "Directores: " + pelicula.pelicula_director;
                var_sinopsis.Text = "Sinopsis: " + pelicula.pelicula_sinopsis;
                var_reparto.Text = "Reparto: " + pelicula.pelicula_reparto;
                if (pelicula.pelicula_imagen != null)
                {
                    var_imagen_pelicula.Image = UtilsProcedimientos.generarImagen(pelicula.pelicula_imagen);
                }
            }
            catch (ControllerException ex)
            {
                PropiedadesGeneralesA.Notificar.notificarError(ex);
            }
        }
    }
}
