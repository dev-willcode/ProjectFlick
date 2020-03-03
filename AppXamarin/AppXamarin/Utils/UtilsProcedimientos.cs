using System.IO;
using AppXamarin.Models;
using Xamarin.Forms;

namespace AppFlickCliente.Utils
{
    public class UtilsProcedimientos
    {
        public static ImageSource generarImagenBytes(byte[] sourceStream, System.Type clase)
        {
            if (clase == typeof(VistaFuncionesModel))
            {
                if (sourceStream == null)
                {
                    return ImageSource.FromFile("pelicula_muestra.jpg");
                }
                else
                {
                    MemoryStream stream = new MemoryStream(sourceStream);
                    return ImageSource.FromStream(() => stream);
                }
            }
            if (clase == typeof(VistaClienteModel))
            {
                if (sourceStream == null)
                {
                    return ImageSource.FromFile("usuario_muestra.jpg");
                }
                else
                {
                    MemoryStream stream = new MemoryStream(sourceStream);
                    return ImageSource.FromStream(() => stream);
                }
            }
            return null;
        }
    }
}
