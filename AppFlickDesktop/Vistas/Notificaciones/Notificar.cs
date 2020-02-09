using System;
using System.Windows.Forms;
using Controllers;

namespace AppFlickCliente.Vistas.Notificaciones
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

        internal bool Preguntar(string titulo, string pregunta)
        {
            DialogResult res = MessageBox.Show(pregunta, titulo, MessageBoxButtons.YesNo);
            return res.ToString().Equals("Yes");
        }

        internal void notificarError(ControllerException ex)
        {
            MessageBox.Show(Environment.NewLine + ex.Message);
        }
    }
}
