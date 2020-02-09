using System;
using System.Windows.Forms;
using Controllers.Controller;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Form_Trailer : Form
    {
        internal CustomFuncionesController CFuncionesController { get; set; }

        public Form_Trailer(CustomFuncionesController cFuncionesController)
        {
            CFuncionesController = cFuncionesController;
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
            string url = CFuncionesController.Pelicula.pelicula_url_trailer +
                "?autoplay=0&modestbranding=1&rel=0&iv_load_policy=3&fs=0&disablekb=1&showinfo=0";
            webview.DocumentText = string.Format(embed, url);
        }

        private void RellenarDatos()
        {
            var_titulo.Text = CFuncionesController.Pelicula.pelicula_titulo;
            var_titulo_original.Text = CFuncionesController.Pelicula.pelicula_titulo_original;
            var_censura.Text = "Censura: " + CFuncionesController.Pelicula.pelicula_tipo_censura;
            var_duracion_pelicula.Text = "Duración: " + CFuncionesController.Pelicula.pelicula_duracion;
            var_categoria.Text = "Categoria: " + CFuncionesController.ObtenerCategorias();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
