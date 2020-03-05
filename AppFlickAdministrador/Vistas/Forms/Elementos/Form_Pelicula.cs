using AppFlickAdministrador.Utils;
using Controllers;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Pelicula : Form
    {

        private readonly Pelicula PeliculaActual;
        private VistaPelicula_Admin VistaPelicula_Admin { get; set; }
        public string Accion { get; set; }
        public bool cambioImagen { get; set; }

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
            DisenoTabla();
            this.CenterToParent();
            if (Accion.Equals(Constantes.accionEditar))
            {
                cargarDatos();
            }
        }

        private void DisenoTabla()
        {
            tablaCategoria.AutoResizeColumns();
            tablaCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablaCategoria.BackgroundColor = Color.FromArgb(45, 45, 45);
            tablaCategoria.ForeColor = Color.White;
            tablaCategoria.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 109, 237);
            tablaCategoria.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaCategoria.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            tablaCategoria.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tablaCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        internal void AnadirCategoria(Categoria categoriaNueva)
        {
            categoriaSource.Add(categoriaNueva);
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
            //categoria source, es un listado de Categorias, ListarPeliculacategoria , 
            //devuelve un listado de Pelicula_categoria
            categoriaSource.DataSource = PropiedadesGenerales.CategoriaController.ListarCategorias(PeliculaActual.id);
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
                        if (categoriaSource.Count == 0)
                        {
                            PropiedadesGenerales.Notificar.notificarFallo("Error", "Ingrese una categoria como mínimo");
                        }
                        else
                        {
                            int idInsertada = PropiedadesGenerales.PeliculaController.Create(pelicula);
                            List<Pelicula_Categoria> lista = CrearListadoCategoria(idInsertada);
                            lista.ForEach(pelicula_categoria =>
                            {
                                PropiedadesGenerales.PeliculaCategoriaController.Create(pelicula_categoria);
                            });
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Pelicula Ingresada");
                            VistaPelicula_Admin.RellenarPeliculas();
                            Close();
                        }                        
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
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar la Pelicula", "Ingrese bien los datos");
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

        private List<Pelicula_Categoria> CrearListadoCategoria(int id)
        {
            List<Pelicula_Categoria> listado = new List<Pelicula_Categoria>();
            Pelicula_Categoria categoria;
        
            foreach (Categoria item in categoriaSource)
            {
                categoria = new Pelicula_Categoria();
                categoria.id_Pelicula = id;
                categoria.id_Categoria = item.id;
                listado.Add(categoria);
            }           
            return listado;
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
                pelicula_url_trailer = txtURL.Text                
            };
            if (cambioImagen) pelicula.pelicula_imagen = UtilsProcedimientos.ImageToByteArray(var_imagen_pelicula.Image);
            else pelicula.pelicula_imagen = PeliculaActual.pelicula_imagen;          
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
                    cambioImagen = true;
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

        private void btnAnadirCategoria_Click(object sender, EventArgs e)
        {
            Form_ListadoCategoria form = new Form_ListadoCategoria(this);
            form.ShowDialog();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            tablaCategoria.Rows.Remove(tablaCategoria.CurrentRow);
        }
    }
}
