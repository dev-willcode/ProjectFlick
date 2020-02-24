using Controllers;
using Controllers.Controller;
using Entity.Entidades;
using System;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Horario : Form
    {
        public readonly Horarios Horario;
        private VistaHorarios_Admin VistaHorarios_Admin { get; set; }
        public int control;
        private HorarioController HorarioController = PropiedadesGenerales.HorarioController;

        public Form_Horario(VistaHorarios_Admin vistaHorarios_Admin, Horarios horario)

        {
            VistaHorarios_Admin = vistaHorarios_Admin;
            Horario = horario;
            InitializeComponent();
            this.CenterToParent();
        }

        private void cargarDatos(Horarios horario)
        {
            try
            {
                txthoraInicio.Text = horario.horario_inicio.ToString();
                txthoraFin.Text = horario.horario_fin.ToString();
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void guardar()
        {
            try
            {
                if (validarCamposHorario())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Error al guardar horario", "Ingrese hora de inicio y hora de fin");
                }
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Horarios horarioTemp = generarHorario();
            try
            {
                Horarios horario = new Horarios();
                horario.horario_inicio = TimeSpan.Parse(txthoraInicio.Text);
                horario.horario_fin = TimeSpan.Parse(txthoraFin.Text);
                if (control == 0)
                {
                    if (HorarioController.RegistrarHorario(horario))
                    {
                        PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Horario ingresado");
                        VistaHorarios_Admin.RellenarHorarios();
                        Close();
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Ingrese hora de inicio y hora de fin");
                    }
                }
                if (control == 1)
                {
                    if (PropiedadesGenerales.HorarioController.Update(horarioTemp))
                    {
                        PropiedadesGenerales.HorarioActual = horarioTemp;
                        PropiedadesGenerales.Notificar.notificarCorrecto("Actualizado",
                            "Horario actualizad0 correctamente");
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                            "Error al actualizar el horario");
                    }
                }
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private Horarios generarHorario()
        {
            Horarios horarios = new Horarios();
            horarios.id = PropiedadesGenerales.HorarioActual.id;
            horarios.horario_inicio = TimeSpan.Parse(txthoraInicio.Text);
            horarios.horario_fin = TimeSpan.Parse(txthoraFin.Text);
            return horarios;

        }

        private bool validarCamposHorario()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txthoraInicio.Text))
            {
                errores += " - Escriba un hora de Incio" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txthoraFin.Text))
            {
                errores += " - Escriba un hora de Fin" + Environment.NewLine;
            }
            return string.IsNullOrEmpty(errores);
        }

        private void Form_Horario_Load(object sender, EventArgs e)
        {
            if (control == 1)
            {
                cargarDatos(Horario);
            }
        }
    }
}
