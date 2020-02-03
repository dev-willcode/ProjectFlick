using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Init;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class Form_Trailer : Form
    {
        private Elem_funcion elem_funcion;

        public Form_Trailer(Elem_funcion elem_funcion)
        {
            InitializeComponent();
            this.elem_funcion = elem_funcion;
            rellenarDatos();
            cargarVideo();
        }

        private void cargarVideo()
        {
            string embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=11\"/>" +
            "</head><body style=\"background-color: rgb(29,29,29);margin: 0; " +
            "border: 0; padding: 0; height: 100 %; width: 100 %;\">" +
            "<iframe width=\"100%\" height=\"427\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            string url = elem_funcion.Pelicula.pelicula_url_trailer +
                "?autoplay=0&modestbranding=1&rel=0&iv_load_policy=3&fs=0&disablekb=1&showinfo=0";
            webview.DocumentText = string.Format(embed, url);
        }

        private void rellenarDatos()
        {
            var_titulo.Text = elem_funcion.Pelicula.pelicula_titulo;
            var_titulo_original.Text = elem_funcion.Pelicula.pelicula_titulo_original;
            var_censura.Text = "Censura: " + elem_funcion.Pelicula.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + elem_funcion.Pelicula.pelicula_duracion;
            var_categoria.Text = "Categoria: " + elem_funcion.obtenerCategorias();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
