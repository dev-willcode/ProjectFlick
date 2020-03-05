using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaTrailer : ContentPage
    {
        public VistaFuncionesModel Funcion { get; set; }
        public VistaTrailer(VistaFuncionesModel funcion)
        {
            InitializeComponent();
            Funcion = funcion;
            abrirVideo();
        }

        private void abrirVideo()
        {
            vistaWeb.Source = Funcion.pelicula_url_trailer;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}