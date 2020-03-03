using AppXamarin.Models;
using AppXamarin.Utils;
using Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        }

        private async void CargarFunciones()
        {
            try
            {
                List<Entity.Entidades.EntidadesPersonalizadas.VistaFunciones> listaFuncionesActivas = 
                    PropiedadesGenerales.VFuncionesController.ListarFuncionesActivas();
                Items = new ObservableCollection<VistaFuncionesModel>();
                listaFuncionesActivas.ForEach(funcion =>
                {
                    Items.Add(new VistaFuncionesModel(funcion));
                });
                ListadoFunciones.ItemsSource = Items;
            }
            catch (ControllerException ex)
            {
                await UtilsNotificaciones.NotificarFallo(this,ex);
            }
        }

        private async void ListadoFunciones_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}