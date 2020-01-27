using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppFlickDesktop.Vistas.Notificaciones
{
    public class Notificar
    {
        internal void notificarCorrecto(string ttitulo, string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        internal void notificarFallo(string ttitulo, string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        internal void notificarWindows(string ttitulo, string mensaje)
        {

        }
    }
}
