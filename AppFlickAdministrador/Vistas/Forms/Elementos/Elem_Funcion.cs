using System;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        public readonly VistaFunciones funcion;

        public Elem_funcion() { }

        public Elem_funcion(VistaFunciones funcion)
        {
            InitializeComponent();
            rellenarDatos(funcion);
            this.funcion = funcion;
        }

        private void rellenarDatos(VistaFunciones funcion)
        {
            try
            {
                var_titulo.Text = funcion.pelicula_titulo;
                var_titulo_original.Text = funcion.pelicula_titulo_original;
                var_censura.Text = "Censura: " + funcion.pelicula_tipo_censura;
                var_duracion_pelicula.Text = "Duración: " + funcion.pelicula_duracion;
                rellenarIdioma(funcion.idioma_abreviatura);
            }
            catch (ControllerException ex)
            {
                PropiedadesGeneralesA.Notificar.notificarError(ex);
            }
        }

        private void rellenarIdioma(string idioma_abreviatura)
        {
            Elem_idioma_funcion elem = new Elem_idioma_funcion(idioma_abreviatura);
            container_idiomas.Controls.Add(elem);
            elem.Dock = DockStyle.Fill;
        }
    }
}
