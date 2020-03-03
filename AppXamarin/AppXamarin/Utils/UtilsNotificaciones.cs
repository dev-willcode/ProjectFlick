using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using Controllers;

namespace AppXamarin.Utils
{
    public class UtilsNotificaciones
    {
        internal static Task NotificarFallo(Page vista, ControllerException ex)
        {
            return vista.DisplayAlert("ALERTA!", ex.Message, "OK");
        }
    }
}
