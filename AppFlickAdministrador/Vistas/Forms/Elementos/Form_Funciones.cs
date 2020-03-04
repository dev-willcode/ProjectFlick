using AppFlickAdministrador.Utils;
using Controllers;
using Entity.Entidades;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
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
            cargarHorarios();
            cargarIdiomas();
            cargarSalas();
            if (Accion.Equals(Constantes.accionEditar))
            {
                cargarDatos();
            }
        }

        private void cargarHorarios()
        {
            try
            {
                List<Horario> lista = PropiedadesGenerales.HorarioController.ListarHorarios();
                comboHorario.DataSource = lista;
                comboHorario.DisplayMember = "horario_inicio";
                comboHorario.ValueMember = "id";
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void cargarIdiomas()
        {
            try
            {
                List<Idioma> lista = PropiedadesGenerales.IdiomaController.ListarIdiomas();
                comboIdioma.DataSource = lista;
                comboIdioma.DisplayMember = "idioma_descripcion";
                comboIdioma.ValueMember = "id";
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void cargarSalas()
        {
            try
            {
                List<Sala_Cine> lista = PropiedadesGenerales.Sala_CineController.ListarSalas();
                comboSala.DataSource = lista;
                comboSala.DisplayMember = "sala_nombre";
                comboSala.ValueMember = "id";
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void cargarDatos()
        {
            txtidPelícula.Text = VFuncionActual.funcion_pelicula.ToString();
            txtTituloP.Text = VFuncionActual.pelicula_titulo;
            txtEstado.Text = VFuncionActual.funcion_estado;
            txtPrecioB.Text = VFuncionActual.funcion_precio_boleto.ToString();
            txtAsientos.Text = VFuncionActual.funcion_asientos_disponibles.ToString();
            dateFechaCreación.Value = VFuncionActual.funcion_fecha_creacion;
            dateFechaFuncion.Value = VFuncionActual.funcion_fecha_evento;
            comboHorario.SelectedIndex = buscarHorario(comboHorario, VFuncionActual.horario_inicio);
            comboIdioma.SelectedIndex = buscarIndice(comboIdioma, VFuncionActual.idioma_descripcion.ToString());
            comboSala.SelectedIndex = buscarIndice(comboSala, VFuncionActual.sala_nombre.ToString());
        }

        private int buscarHorario(ComboBox comboBox, TimeSpan value)
        {
            foreach (object item in comboBox.Items)
            {
                if (item.GetType() == typeof(Horario))
                {
                    if ((item as Horario).horario_inicio.Equals(value))
                    {
                        return comboBox.Items.IndexOf(item);
                    }
                }
            }
            return -1;
        }

        private int buscarIndice(ComboBox combobox, string value)
        {
            foreach (object item in combobox.Items)
            {
                if (item.GetType() == typeof(Idioma))
                {
                    if ((item as Idioma).idioma_descripcion.Equals(value))
                    {
                        return combobox.Items.IndexOf(item);
                    }
                }
                else
                {
                    if ((item as Sala_Cine).sala_nombre.Equals(value))
                    {
                        return combobox.Items.IndexOf(item);
                    }
                }
            }
            return -1;
        }

        private bool ValidarCamposFuncion()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txtidPelícula.Text))
            {
                errores += " - Busque un nombre de la pelicula" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                errores += " - Ingrese el estado de la pelicula" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtPrecioB.Text))
            {
                errores += " - Ingrese el precio de boleto de la pelicula" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtAsientos.Text))
            {
                errores += " - Ingrese el número de asientos de la pelicula" + Environment.NewLine;
            }
            return string.IsNullOrEmpty(errores);
        }



        private void NuevaFuncion()
        {
            if (ValidarCamposFuncion())
            {
                try
                {
                    Funcion funcion = new Funcion();
                    funcion.funcion_pelicula = int.Parse(txtidPelícula.Text);
                    funcion.funcion_estado = txtEstado.Text;
                    funcion.funcion_precio_boleto = decimal.Parse(txtPrecioB.Text);
                    funcion.funcion_asientos_disponibles = int.Parse(txtAsientos.Text);
                    funcion.funcion_fecha_creacion = dateFechaCreación.Value;
                    funcion.funcion_fecha_evento = dateFechaFuncion.Value;
                    funcion.funcion_horario = int.Parse(comboHorario.SelectedValue.ToString());
                    funcion.funcion_idioma = int.Parse(comboIdioma.SelectedValue.ToString());
                    funcion.funcion_sala = int.Parse(comboSala.SelectedValue.ToString());
                    if (dateFechaFuncion.Value >= DateTime.Now)
                    {
                        try
                        {
                            PropiedadesGenerales.FuncionesController.Create(funcion);
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Funcion Ingresada");
                            VistaFunciones_Admin.RellenarFuncionesActivas();
                            Close();
                        }
                        catch (ControllerException ex)
                        {
                            PropiedadesGenerales.Notificar.notificarError(ex);
                        }
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar Funcion", "La fecha de la fucnión no puede ser anterior al día de hoy ");
                    }
                }
                catch (ControllerException ex)
                {

                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar Funcion", "Ingrese bien los datos");
            }
        }

        private void EditarFuncion()
        {
            if (ValidarCamposFuncion())
            {
                Funcion funcionTemp = generarFuncion();
                if (!funcionTemp.Equals(FuncionActual))
                {
                    if (dateFechaFuncion.Value >= DateTime.Now)
                    {
                        try
                        {
                            if (PropiedadesGenerales.FuncionesController.Update(funcionTemp))
                            {
                                PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Funcion actualizada");
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
                        PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar Funcion", "La fecha de la fucnión no puede ser anterior al día de hoy ");
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar", "No cambio ningun dato!");
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar la Funcion", "Ingrese bien los datos");
            }
        }


        private Funcion generarFuncion()
        {
            Funcion funcion = new Funcion()
            {
                id = VFuncionActual.id,
                funcion_pelicula = int.Parse(txtidPelícula.Text),
                funcion_sala = int.Parse(comboSala.SelectedValue.ToString()),
                funcion_fecha_evento = dateFechaFuncion.Value,
                funcion_horario = int.Parse(comboHorario.SelectedValue.ToString()),
                funcion_estado = txtEstado.Text,
                funcion_precio_boleto = decimal.Parse(txtPrecioB.Text),
                funcion_fecha_creacion = dateFechaCreación.Value,
                funcion_idioma = int.Parse(comboIdioma.SelectedValue.ToString()),
                funcion_asientos_disponibles = int.Parse(txtAsientos.Text)
            };
            return funcion;
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
