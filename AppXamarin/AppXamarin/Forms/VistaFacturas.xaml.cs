﻿using AppXamarin.Models;
using AppXamarin.Utils;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaFacturas : ContentPage
    {
        public ObservableCollection<VistaFacturaModel> Items { get; set; }
        public VistaFacturas()
        {
            InitializeComponent();
            CargarFacturas();
            asignarRefresh();
        }

        private void asignarRefresh()
        {
            ListadoFacturas.RefreshCommand = new Command(() => CargarFacturas());
        }

        private async void CargarFacturas()
        {
            try
            {
                Items = new ObservableCollection<VistaFacturaModel>();
                List<VistaFacturaFuncion> lista = PropiedadesGenerales.VFacturaFuncionController
                    .ListarFacturas(PropiedadesGenerales.ClienteActual.id);
                lista.ForEach(factura =>
                {
                    Items.Add(new VistaFacturaModel(factura));
                });
                ListadoFacturas.ItemsSource = Items;
                ListadoFacturas.IsRefreshing = false;
            }
            catch (ControllerException ex)
            {
                await UtilsNotificaciones.NotificarFallo(this, ex);
            }
        }
    }
}