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

        private void nuevo()
        {
            if (validarCamposHorario())
            {
                try
                {
                    Horarios horario = new Horarios();
                    horario.horario_inicio = TimeSpan.Parse(txthoraInicio.Text);
                    horario.horario_fin = TimeSpan.Parse(txthoraFin.Text);
                    TimeSpan timeSpan = TimeSpan.FromHours(-1);
                    TimeSpan timeDiferencia = TimeSpan.Parse(txthoraInicio.Text) - TimeSpan.Parse(txthoraFin.Text);
                    if (txthoraInicio.Text != txthoraFin.Text)
                    {
                        if (TimeSpan.Parse(txthoraInicio.Text) < TimeSpan.Parse(txthoraFin.Text))
                        {
                            if (timeDiferencia <= timeSpan)
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
                            else
                            {
                                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Hora de Inicio y Hora de Fin deben tener diferencia de 1 hora");
                            }
                        }
                        else
                        {
                            PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Hora de Inicio es tiempo antes que Hora Fin");
                        }
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Hora de Inicio y Hora de Fin no pueden ser iguales");
                    }
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Ingrese hora de inicio y hora de fin");
            }
        }

        private void editar()
        {
            if (validarCamposHorario())
            {
                Horarios horarioTemp = generarHorario();
                TimeSpan timeSpan = TimeSpan.FromHours(-1);
                TimeSpan timeDiferencia = TimeSpan.Parse(txthoraInicio.Text) - TimeSpan.Parse(txthoraFin.Text);
                if (!horarioTemp.Equals(PropiedadesGenerales.HorarioActual))
                {
                    try
                    {
                        if (txthoraInicio.Text != txthoraFin.Text)
                        {
                            if (TimeSpan.Parse(txthoraInicio.Text) < TimeSpan.Parse(txthoraFin.Text))
                            {
                                if (timeDiferencia <= timeSpan)
                                {
                                    if (HorarioController.Update(horarioTemp) && validarCamposHorario())
                                    {
                                        PropiedadesGenerales.HorarioActual = horarioTemp;
                                        VistaHorarios_Admin.RellenarHorarios();
                                        PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Horario actualizado");
                                        Close();
                                    }
                                    else
                                    {
                                        PropiedadesGenerales.Notificar.notificarFallo("Error al actualizar horario", "Ingrese hora de inicio y hora de fin");
                                    }
                                }
                                else
                                {
                                    PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Hora de Inicio y Hora de Fin deben tener diferencia de 1 hora");
                                }
                            }
                            else
                            {
                                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Hora de Inicio es tiempo antes que Hora Fin");
                            }
                        }
                        else
                        {
                            PropiedadesGenerales.Notificar.notificarFallo("Error al actualizar horario", "Hora de Inicio y Hora de Fin no pueden ser iguales");
                        }
                    }
                    catch (ControllerException ex)
                    {
                        PropiedadesGenerales.Notificar.notificarError(ex);
                    }
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Ingrese hora de inicio y hora de fin");
            }
        }

        private Horarios generarHorario()
        {
            Horarios horario = new Horarios();
            //horario.id = PropiedadesGenerales.HorarioActual.id;
            horario.horario_inicio = TimeSpan.Parse(txthoraInicio.Text);
            horario.horario_fin = TimeSpan.Parse(txthoraFin.Text);
            return horario;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                nuevo();
            }
            if (control == 1)
            {
                editar();
            }
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

        private void txthoraInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txthoraFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
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
