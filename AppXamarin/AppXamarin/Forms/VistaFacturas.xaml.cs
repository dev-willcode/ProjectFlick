﻿using AppXamarin.Models;
using AppXamarin.Utils;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        }

        private async void CargarFacturas()
        {
            try
            {
                // Codigo exclusivo para pruebas
                PropiedadesGenerales.ClienteActual = new Entity.Entidades.Cliente()
                {
                    id = 1
                };

                List<VistaFacturaFuncion> lista = PropiedadesGenerales.VFacturaFuncionController
                    .ListarFacturas(PropiedadesGenerales.ClienteActual.id);
                lista.ForEach(factura =>
                {
                    Items.Add(new VistaFacturaModel(factura));
                });
                ListadoFunciones.ItemsSource = Items;
            }
            catch (ControllerException ex)
            {
                await UtilsNotificaciones.NotificarFallo(this, ex);
            }
        }
    }
}