using System.Drawing;
using System.IO;

namespace AppFlickCliente.Utils
{
    public class UtilsProcedimientos
    {
        public static Image generarImagen(byte[] pelicula_imagen)
        {
            using (MemoryStream stream = new MemoryStream(pelicula_imagen))
            {
                return Image.FromStream(stream);
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
