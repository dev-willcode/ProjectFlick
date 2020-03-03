using AppFlickCliente.Utils;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppXamarin.Models
{
    public class VistaFuncionesModel : VistaFunciones
    {
        public VistaFuncionesModel(VistaFunciones funcion)
        {
            id = funcion.id;
            funcion_pelicula = funcion.funcion_pelicula;
            pelicula_titulo = funcion.pelicula_titulo;
            pelicula_titulo_original = funcion.pelicula_titulo_original;
            idioma_abreviatura = funcion.idioma_abreviatura;
            horario_inicio = funcion.horario_inicio;
            pelicula_duracion = funcion.pelicula_duracion;
            pelicula_tipo_censura = funcion.pelicula_tipo_censura;
            pelicula_url_trailer = funcion.pelicula_url_trailer;
            pelicula_sinopsis = funcion.pelicula_sinopsis;
            pelicula_director = funcion.pelicula_director;
            pelicula_reparto = funcion.pelicula_reparto;
            funcion_fecha_evento = funcion.funcion_fecha_evento;
            funcion_estado = funcion.funcion_estado;
            funcion_precio_boleto = funcion.funcion_precio_boleto;
            sala_nombre = funcion.sala_nombre;
            idioma_descripcion = funcion.idioma_descripcion;
            funcion_asientos_disponibles = funcion.funcion_asientos_disponibles;
            funcion_fecha_creacion = funcion.funcion_fecha_creacion;
            pelicula_imagen = funcion.pelicula_imagen;
            imagen_generada = UtilsProcedimientos.generarImagenBytes(pelicula_imagen, GetType());
        }

        public ImageSource imagen_generada { get; set; }
    }
}
