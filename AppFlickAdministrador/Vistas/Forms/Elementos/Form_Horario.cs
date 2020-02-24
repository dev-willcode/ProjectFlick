using Controllers;
using Controllers.Controller;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Horario : Form
    {
        public readonly Horarios Horario;
        private HorarioController HorarioController = PropiedadesGeneralesA.HorarioController;
        private VistaHorarios_Admin VistaHorarios_Admin { get; set; }
        public int control;

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
                PropiedadesGeneralesA.Notificar.notificarError(ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // Horarios horarioTemp = generarHorario();
            if (validarCamposHorario())
            {
                Horarios horario = new Horarios();
                horario.horario_inicio = TimeSpan.Parse(txthoraInicio.Text);
                horario.horario_fin = TimeSpan.Parse(txthoraFin.Text);
                if (HorarioController.RegistrarHorario(horario))
                {
                    PropiedadesGeneralesA.Notificar.notificarCorrecto("Completado", "Horario ingresado");
                    VistaHorarios_Admin.RellenarHorarios();
                    Close();
                }
                else
                {
                    PropiedadesGeneralesA.Notificar.notificarFallo("Error al ingresar horario", "Ingrese hora de inicio y hora de fin");
                }
            }
            else
            {
                PropiedadesGeneralesA.Notificar.notificarFallo("Faltan datos", "Complete todos los campos!");
            }
        }

        private Horarios generarHorario()
        {
            Horarios horarios = new Horarios();
            horarios.id = PropiedadesGeneralesA.HorarioActual.id;
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
