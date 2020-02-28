using System;
using System.Windows.Forms;
using AppFlickAdministrador.Utils;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Horario : Form
    {
        private readonly Horario HorarioActual;
        private VistaHorarios_Admin VistaHorarios_Admin { get; set; }
        public string Accion { get; set; }

        public Form_Horario(VistaHorarios_Admin vistaHorarios_Admin, string titulo)
        {
            Accion = Constantes.accionInsertar;
            inicializarformulario(vistaHorarios_Admin, titulo);
        }

        public Form_Horario(VistaHorarios_Admin vistaHorarios_Admin,
            string titulo, Horario horario)
        {
            Accion = Constantes.accionEditar;
            HorarioActual = horario;
            inicializarformulario(vistaHorarios_Admin, titulo);
        }

        private void inicializarformulario(VistaHorarios_Admin vistaHorarios_Admin, string titulo)
        {
            VistaHorarios_Admin = vistaHorarios_Admin;
            Text = titulo;
            InitializeComponent();
            if (Accion.Equals(Constantes.accionEditar))
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            txthoraInicio.Text = HorarioActual.horario_inicio.ToString();
            txthoraFin.Text = HorarioActual.horario_fin.ToString();
        }

        private void NuevoHorario()
        {
            if (ValidarCamposHorario())
            {
                try
                {
                    Horario horario = new Horario();
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
                                try
                                {
                                    PropiedadesGenerales.HorarioController.Create(horario);
                                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Horario ingresado");
                                    VistaHorarios_Admin.RellenarHorarios();
                                    Close();
                                }
                                catch (ControllerException ex)
                                {
                                    PropiedadesGenerales.Notificar.notificarError(ex);
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

        private void EditarHorario()
        {
            if (ValidarCamposHorario())
            {
                Horario horarioTemp = generarHorario();
                TimeSpan timeSpan = TimeSpan.FromHours(-1);
                TimeSpan timeDiferencia = TimeSpan.Parse(txthoraInicio.Text) - TimeSpan.Parse(txthoraFin.Text);
                if (!horarioTemp.Equals(HorarioActual))
                {
                    try
                    {
                        if (txthoraInicio.Text != txthoraFin.Text)
                        {
                            if (TimeSpan.Parse(txthoraInicio.Text) < TimeSpan.Parse(txthoraFin.Text))
                            {
                                if (timeDiferencia <= timeSpan)
                                {
                                    if (ValidarCamposHorario() && PropiedadesGenerales.HorarioController.Update(horarioTemp))
                                    {
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
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "No ha hecho ningun cambio!");
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar horario", "Ingrese hora de inicio y hora de fin");
            }
        }

        private Horario generarHorario()
        {
            Horario horario = new Horario
            {
                id = HorarioActual.id,
                horario_inicio = TimeSpan.Parse(txthoraInicio.Text),
                horario_fin = TimeSpan.Parse(txthoraFin.Text)
            };
            return horario;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(Constantes.accionInsertar))
            {
                NuevoHorario();
            }
            else
            {
                EditarHorario();
            }
        }

        private bool ValidarCamposHorario()
        {
            ValidarFormato();
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

        private void ValidarFormato()
        {
            if (txthoraInicio.Text.Length == 1)
            {
                txthoraInicio.Text = "0" + txthoraInicio.Text + ":00:00";
            }
            else if (txthoraInicio.Text.Length == 2)
            {
                txthoraInicio.Text += ":00:00";

            }
            else if (txthoraInicio.Text.Length == 5)
            {
                txthoraInicio.Text += ":00";
            }
            if (txthoraFin.Text.Length == 1)
            {
                txthoraFin.Text = "0" + txthoraFin.Text + ":00:00";
            }
            else if (txthoraFin.Text.Length == 2)
            {
                txthoraFin.Text += ":00:00";
            }
            else if (txthoraFin.Text.Length == 5)
            {
                txthoraFin.Text += ":00";
            }
        }

        private void TxthoraInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else
              if (char.IsControl(e.KeyChar))
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
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else
              if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
