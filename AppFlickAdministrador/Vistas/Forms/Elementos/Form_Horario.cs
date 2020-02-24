using Controllers;
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
        public readonly Horarios horario;

        public Form_Horario(Horarios horario)

        {
            InitializeComponent();           
            this.CenterToParent();
            cargarDatos(horario);
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

        }
    }
}
