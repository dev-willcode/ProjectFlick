using System;
using System.Threading.Tasks;
using Controllers;
using Xamarin.Forms;

namespace AppXamarin.Utils
{
    public class UtilsNotificaciones
    {
        internal static Task NotificarFallo(Page vista, ControllerException ex)
        {
            return vista.DisplayAlert("ALERTA!", ex.Message, "OK");
        }

        internal static Task NotificarError(Page vista, string titulo, string descripcion)
        {
            return vista.DisplayAlert(titulo, descripcion, "OK");
        }
    }
}
