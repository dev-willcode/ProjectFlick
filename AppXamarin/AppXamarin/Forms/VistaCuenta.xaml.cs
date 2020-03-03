using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamarin.Models;
using Entity.Entidades;
using Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaCuenta : ContentPage
	{
		public VistaCuenta ()
		{
			InitializeComponent ();
			BindingContext = new VistaClienteModel(PropiedadesGenerales.ClienteActual);
		}
	}
}