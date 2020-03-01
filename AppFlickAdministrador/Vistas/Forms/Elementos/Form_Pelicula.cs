using System;
using System.Drawing;
using Utils;
using System.Windows.Forms;
using Controllers;
using Entity.Entidades;
using AppFlickAdministrador.Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Pelicula : Form
    {

        private readonly Pelicula PeliculaActual;
        private VistaPelicula_Admin VistaPelicula_Admin { get; set; }
        public string Accion { get; set; }

        public Form_Pelicula(VistaPelicula_Admin vistaPelicula_Admin, string titulo)
        {
            Accion = Constantes.accionInsertar;
            inicializarformulario(vistaPelicula_Admin, titulo);
        }

        public Form_Pelicula(VistaPelicula_Admin vistaPelicula_Admin,
            string titulo, Pelicula pelicula)
        {
            Accion = Constantes.accionEditar;
            PeliculaActual = pelicula;
            inicializarformulario(vistaPelicula_Admin, titulo);
        }

        private void inicializarformulario(VistaPelicula_Admin vistaPelicula_Admin, string titulo)
        {
            VistaPelicula_Admin = vistaPelicula_Admin;
            Text = titulo;
            InitializeComponent();
            this.CenterToParent();
            if (Accion.Equals(Constantes.accionEditar))
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            txtTitulo.Text = PeliculaActual.pelicula_titulo.ToString();
            txtTituloOriginal.Text = PeliculaActual.pelicula_titulo_original.ToString();
            txtDuracion.Text = PeliculaActual.pelicula_duracion.ToString();
            txtCensura.Text = PeliculaActual.pelicula_tipo_censura.ToString();
            txtSinopsis.Text = PeliculaActual.pelicula_sinopsis.ToString();
            txtDirector.Text = PeliculaActual.pelicula_director.ToString();
            txtReparto.Text = PeliculaActual.pelicula_reparto.ToString();
            txtURL.Text = PeliculaActual.pelicula_url_trailer.ToString();
            if (PeliculaActual.pelicula_imagen != null)
            {
                var_imagen_pelicula.Image = UtilsProcedimientos.generarImagen(PeliculaActual.pelicula_imagen);
            }
        }

        private bool ValidarCamposPelicula()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                errores += " - Escriba el título" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtTituloOriginal.Text))
            {
                errores += " - Escriba el título original" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtDuracion.Text))
            {
                errores += " - Escriba la duración" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtCensura.Text))
            {
                errores += " - Escriba el tipo de censura" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                errores += " - Escriba la sinopsis" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtDirector.Text))
            {
                errores += " - Escriba el director" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtReparto.Text))
            {
                errores += " - Escriba el reparto" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtURL.Text))
            {
                errores += " - Escriba la URL del Trailer" + Environment.NewLine;
            }
            return string.IsNullOrEmpty(errores);
        }

        private void NuevaPelicula()
        {
            if (ValidarCamposPelicula())
            {
                try
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.pelicula_titulo = txtTitulo.Text.ToString();
                    pelicula.pelicula_titulo_original = txtTituloOriginal.Text.ToString();
                    pelicula.pelicula_duracion = txtDuracion.Text.ToString();
                    pelicula.pelicula_tipo_censura = txtCensura.Text.ToString();
                    pelicula.pelicula_sinopsis = txtSinopsis.Text.ToString();
                    pelicula.pelicula_director = txtDirector.Text.ToString();
                    pelicula.pelicula_reparto = txtReparto.Text.ToString();
                    pelicula.pelicula_url_trailer = txtURL.Text.ToString();
                    pelicula.pelicula_imagen = UtilsProcedimientos.ImageToByteArray(var_imagen_pelicula.Image);                 
                    try
                    {
                        PropiedadesGenerales.PeliculaController.Create(pelicula);
                        PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Pelicula Ingresada");
                        VistaPelicula_Admin.RellenarPeliculas();
                        Close();
                    }
                    catch (ControllerException ex)
                    {
                        PropiedadesGenerales.Notificar.notificarError(ex);
                    }
                }
                catch (ControllerException ex)
                {

                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar cliente", "Ingrese bien los datos");
            }
        }

        private void EditarPelicula()
        {
            if (ValidarCamposPelicula())
            {
                Pelicula peliculaTemp = generarPelicula();
                if (!peliculaTemp.Equals(PeliculaActual))
                {
                    try
                    {
                        if (PropiedadesGenerales.PeliculaController.Update(peliculaTemp))
                        {
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Pelicula actualizada");
                            VistaPelicula_Admin.RellenarPeliculas();
                            Close();
                        }
                        else
                        {
                            PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                                "Error al actualizar la pelicula");
                        }
                    }
                    catch (ControllerException ex)
                    {
                        PropiedadesGenerales.Notificar.notificarError(ex);
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar", "No cambio ningun dato!");
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar la pelicula", "Ingrese bien los datos");
            }
        }


        private Pelicula generarPelicula()
        {
            Pelicula pelicula = new Pelicula()
            {
                id = PeliculaActual.id,
                pelicula_titulo = txtTitulo.Text,
                pelicula_titulo_original = txtTituloOriginal.Text,
                pelicula_duracion = txtDuracion.Text,
                pelicula_tipo_censura = txtCensura.Text,
                pelicula_sinopsis = txtSinopsis.Text,
                pelicula_director = txtDirector.Text,
                pelicula_reparto = txtReparto.Text,
                pelicula_url_trailer = txtURL.Text,
                pelicula_imagen = UtilsProcedimientos.ImageToByteArray(var_imagen_pelicula.Image)
        };
            return pelicula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(Constantes.accionInsertar))
            {
                NuevaPelicula();
            }
            else
            {
                EditarPelicula();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectorArchivo.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(SelectorArchivo.FileName);
                    byte[] bitarray = UtilsProcedimientos.ImageToByteArray(img);
                    var_imagen_pelicula.Image = img;
                }
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCensura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '+' || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDirector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
