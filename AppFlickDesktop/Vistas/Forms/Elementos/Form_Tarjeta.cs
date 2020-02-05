using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Form_Tarjeta : Form
    {
        public Form_Tarjeta()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void cargarCombos()
        {
            cargarBancos();
            cargarMesAnio();
        }

        private void cargarBancos()
        {
            List<Banco> lista = PropiedadesGenerales.BancoController.ListarBancosActivos();
            comboBancos.DataSource = lista;
            comboBancos.DisplayMember = "banco_nombre";
            comboBancos.ValueMember = "id";
        }

        private void cargarMesAnio()
        {
            List<string> listaMes = new List<string>{"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre"
            ,"Octubre","Noviembre","Diciembre"};
            comboMes.DataSource = listaMes;
            List<string> listaAnio = new List<string>();
            for (int i = 2017; i < 2030; i++)
            {
                listaAnio.Add(i.ToString());
            }
            comboAnio.DataSource = listaAnio;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
