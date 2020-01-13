using System;
using System.Collections.Generic;
using System.Text;

namespace FlickLibrary.Mediadores
{
    public class Med_Factura
    {
        public Med_Factura()
        {
        }

        public string Numero_facura { get; set; }
        public string Nombre_pelicula { get; set; }
        public string Fecha_funcion { get; set; }
        public string Hora_funcion { get; set; }
        public int Cantidad_boletos { get; set; }
        public double Precio_total { get; set; }
    }
}
