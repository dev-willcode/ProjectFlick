using System.Collections.Generic;
using System.Collections.ObjectModel;
using AppXamarin.Models;
using AppXamarin.Utils;
using Controllers;
using Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaFunciones : ContentPage
    {
        public ObservableCollection<VistaFuncionesModel> Items { get; set; }
        public VistaFunciones()
        {
            InitializeComponent();
            CargarFunciones();
            asignarRefresh();
        }

        private void asignarRefresh()
        {
            ListadoFunciones.RefreshCommand = new Command(() => CargarFunciones());
        }

        private async void CargarFunciones()
        {
            try
            {
                Items = new ObservableCollection<VistaFuncionesModel>();
                List<Entity.Entidades.EntidadesPersonalizadas.VistaFunciones> listaFuncionesActivas =
                    PropiedadesGenerales.VFuncionesController.ListarFuncionesActivas();
                listaFuncionesActivas.ForEach(funcion =>
                {
                    Items.Add(new VistaFuncionesModel(funcion));
                });
                ListadoFunciones.ItemsSource = Items;
                ListadoFunciones.IsRefreshing = false;
            }

            catch (ControllerException ex)
            {
                await UtilsNotificaciones.NotificarFallo(this, ex);
            }
        }

        private void ListadoFunciones_ItemSelected(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            Navigation.PushModalAsync(new VistaFuncion((VistaFuncionesModel)e.Item));
            ((ListView)sender).SelectedItem = null;
        }
    }
}