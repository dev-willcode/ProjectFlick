using System;
using AppXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaFuncion : ContentPage
    {
        public VistaFuncionesModel Funcion { get; set; }
        public VistaFuncion(VistaFuncionesModel funcion)
        {
            funcion.generarImagen();
            InitializeComponent();
            Funcion = funcion;
            BindingContext = funcion;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VistaTrailer(Funcion));
        }
    }
}