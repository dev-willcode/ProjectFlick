using System;
using System.Windows.Forms;
using Entity.Entidades.EntidadesPersonalizadas;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Form_Trailer : Form
    {
        private readonly VistaFunciones funcion;

        public Form_Trailer(VistaFunciones funcion)
        {
            this.funcion = funcion;
            InitializeComponent();
            RellenarDatos();
            CargarVideo();
        }

        private void CargarVideo()
        {
            string embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=11\"/>" +
            "</head><body style=\"background-color: rgb(29,29,29);margin: 0; " +
            "border: 0; padding: 0; height: 100 %; width: 100 %;\">" +
            "<iframe width=\"100%\" height=\"427\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            string url = funcion.pelicula_url_trailer +
                "?autoplay=0&modestbranding=1&rel=0&iv_load_policy=3&fs=0&disablekb=1&showinfo=0";
            webview.DocumentText = string.Format(embed, url);
        }

        private void RellenarDatos()
        {
            var_titulo.Text = funcion.pelicula_titulo;
            var_titulo_original.Text = funcion.pelicula_titulo_original;
            var_censura.Text = "Censura: " + funcion.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + funcion.pelicula_duracion;
            var_categoria.Text = funcion.categorias;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
