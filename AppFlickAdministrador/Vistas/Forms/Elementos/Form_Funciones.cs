using AppFlickAdministrador.Utils;
using Controllers;
using Entity.Entidades;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Funciones : Form
    {
        private readonly Funcion FuncionActual;
        private readonly VistaFunciones VFuncionActual;
        private VistaFunciones_Admin VistaFunciones_Admin { get; set; }
        public string Accion { get; set; }

        public Form_Funciones(VistaFunciones_Admin vistaFunciones_Admin, string titulo)
        {
            Accion = Constantes.accionInsertar;
            inicializarformulario(vistaFunciones_Admin, titulo);
        }

        public Form_Funciones(VistaFunciones_Admin vistaFunciones_Admin, string titulo, 
            VistaFunciones vistaFuncion)
        {
            Accion = Constantes.accionEditar;
            VFuncionActual = vistaFuncion;
            inicializarformulario(vistaFunciones_Admin, titulo);
        }

        public Form_Funciones(VistaFunciones_Admin vistaFunciones_Admin, string titulo, 
            Funcion funcion)
        {
            Accion = Constantes.accionEditar;
            FuncionActual = funcion;
            inicializarformulario(vistaFunciones_Admin, titulo);
        }

        private void inicializarformulario(VistaFunciones_Admin vistaFunciones_Admin, string titulo)
        {
            VistaFunciones_Admin = vistaFunciones_Admin;
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
        }

        private bool ValidarCamposFuncion()
        {
            string errores = "";
            /*if (string.IsNullOrEmpty(txtTitulo.Text))
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
            }*/
            return string.IsNullOrEmpty(errores);
        }

        private void NuevaFuncion()
        {
            if (ValidarCamposFuncion())
            {
                try
                {
                    Funcion funcion = new Funcion();
                    try
                    {
                        PropiedadesGenerales.FuncionesController.Create(funcion);
                        PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Pelicula Ingresada");
                        VistaFunciones_Admin.RellenarFuncionesActivas();
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

        private void EditarFuncion()
        {
            if (ValidarCamposFuncion())
            {
                Funcion funcionTemp = generarFuncion();
                if (!funcionTemp.Equals(FuncionActual))
                {
                    try
                    {
                        if (PropiedadesGenerales.FuncionesController.Update(funcionTemp))
                        {
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Pelicula actualizada");
                            VistaFunciones_Admin.RellenarFuncionesActivas();
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


        private Funcion generarFuncion()
        {
            Funcion funcion = new Funcion()
            {
            };
            return funcion;
        }

        private void txtPelícula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(Constantes.accionInsertar))
            {
                NuevaFuncion();
            }
            else
            {
                EditarFuncion();
            }
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }          
        }

        private void txtAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form_ListadoPeliculas form = new Form_ListadoPeliculas();
            form.ShowDialog();
        }
    }
}
