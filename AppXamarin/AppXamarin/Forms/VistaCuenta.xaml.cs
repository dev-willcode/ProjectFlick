using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaCuenta : ContentPage
	{
		public Cliente Cliente { get; set; }
		public VistaCuenta ()
		{
			Cliente = new Cliente();
			Cliente.cliente_cedula = "0700";
			InitializeComponent ();
			CargarDatosCuenta();
		}

		private void CargarDatosCuenta()
		{
			
		}
	}
}