using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_funcion : UserControl
    {
        public readonly VistaFunciones funcion;

        private VistaFunciones_Admin VistaFunciones_Admin { get; set; }

        public Elem_funcion() { }

        public Elem_funcion(VistaFunciones_Admin vistaFunciones_Admin,VistaFunciones funcion)
        {
            InitializeComponent();
            rellenarDatos(funcion);
            this.funcion = funcion;
            VistaFunciones_Admin = vistaFunciones_Admin;
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
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void rellenarIdioma(string idioma_abreviatura)
        {
            Elem_idioma_funcion elem = new Elem_idioma_funcion(idioma_abreviatura);
            container_idiomas.Controls.Add(elem);
            elem.Dock = DockStyle.Fill;
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Form_Funciones form = new Form_Funciones(VistaFunciones_Admin, "Editar Función", funcion);
            form.ShowDialog();
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGenerales.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                try
                {
                    PropiedadesGenerales.FuncionesController.Delete(funcion.id);
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Se ha eliminado la funcion");
                    VistaFunciones_Admin.RellenarFuncionesActivas();
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
        }
    }
}
