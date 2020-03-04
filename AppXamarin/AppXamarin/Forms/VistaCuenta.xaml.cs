using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamarin.Init;
using AppXamarin.Models;
using Entity.Entidades;
using Utils;
using Xamarin.Forms;
using System.Drawing;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaCuenta : ContentPage
	{
		public VistaCuenta ()
		{
			InitializeComponent ();
			BindingContext = PropiedadesGenerales.ClienteActual;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			PropiedadesGenerales.ClienteActual = null;
			Application.Current.MainPage = new Login();
			GC.Collect();
		}
	}
}