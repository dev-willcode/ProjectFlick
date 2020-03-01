using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_pelicula : UserControl
    {
        public readonly Pelicula Pelicula;
        private VistaPelicula_Admin VistaPelicula_Admin { get; set; }

        public Elem_pelicula() { }

        public Elem_pelicula(VistaPelicula_Admin vistaPelicula_Admin,Pelicula pelicula)
        {
            InitializeComponent();
            rellenarDatos(pelicula);
            Pelicula = pelicula;
            VistaPelicula_Admin = vistaPelicula_Admin;
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
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Form_Pelicula form = new Form_Pelicula(VistaPelicula_Admin, "Editar Pelicula", Pelicula);
            form.ShowDialog();
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGenerales.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                try
                {
                    PropiedadesGenerales.PeliculaController.Delete(Pelicula.id);
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Se ha eliminado la pelicula");
                    VistaPelicula_Admin.RellenarPeliculas();
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
        }
    }
}
