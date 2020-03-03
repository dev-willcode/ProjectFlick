using System.IO;
using Xamarin.Forms;

namespace AppFlickCliente.Utils
{
    public class UtilsProcedimientos
    {
        public static ImageSource generarImageSourcen(byte[] pelicula_ImageSource)
        {
            if (pelicula_ImageSource == null)
            {
                return ImageSource.FromFile("pelicula_muestra.jpg");
            }
            else
            {
                MemoryStream stream = new MemoryStream(pelicula_ImageSource);
                return ImageSource.FromStream(() => stream);
            }
        }
    }
}
