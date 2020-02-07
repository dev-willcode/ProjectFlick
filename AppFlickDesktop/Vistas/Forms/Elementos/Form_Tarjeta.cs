using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers.Controller;
using Entity.Entidades;
using Utils;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Form_Tarjeta : Form
    {

        private TarjetasController TarjetaController = PropiedadesGenerales.TarjetasController;
        private VistaCuenta_Cliente VistaCuenta_Cliente { get; set; }

        public Form_Tarjeta() { }

        public Form_Tarjeta(VistaCuenta_Cliente vistaCuenta_Cliente)
        {
            VistaCuenta_Cliente = vistaCuenta_Cliente;
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
            List<string> listaMes = new List<string>{
                "Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio",
                "Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            comboMes.DataSource = listaMes;
            List<string> listaAnio = new List<string>();
            for (int i = 2017; i < 2030; i++)
            {
                listaAnio.Add(i.ToString());
            }
            comboAnio.DataSource = listaAnio;
        }

        private bool validarCamposTarjeta()
        {
            string errores = "";
            if (string.IsNullOrEmpty(comboBancos.Text))
            {
                errores += " - Seleccion una Entidad Bancaria" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(comboAnio.Text))
            {
                errores += " - Seleccione el Año" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(comboMes.Text))
            {
                errores += " - Seleccione el Mes" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtCCV.Text))
            {
                errores += " - Ingrese el CCV" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtNumeroTarjeta.Text))
            {
                errores += " - Ingrese el número de la tarjeta" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtPropietario.Text))
            {
                errores += " - Ingrese el nombre del Propietario de la tarjeta" + Environment.NewLine;
            }

            return string.IsNullOrEmpty(errores);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCamposTarjeta())
            {
                Tarjetas tarjeta = new Tarjetas();
                tarjeta.tarjeta_numero = txtNumeroTarjeta.Text;

                if (!TarjetaController.TarjetaRepetida(tarjeta))
                {
                    tarjeta.tarjeta_banco = int.Parse(comboBancos.SelectedValue.ToString());
                    tarjeta.tarjeta_anio = comboAnio.SelectedValue.ToString();
                    tarjeta.tarjeta_mes = comboMes.SelectedValue.ToString();
                    tarjeta.tarjeta_tipo = comboTipo.Text;
                    tarjeta.tarjeta_ccv = txtCCV.Text;
                    tarjeta.tarjeta_propietario = txtPropietario.Text;
                    tarjeta.tarjeta_numero = txtNumeroTarjeta.Text;

                    if (TarjetaController.RegistrarTarjeta(tarjeta))
                    {
                        PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Tarjeta ingresada");
                        VistaCuenta_Cliente.rellenarTarjetas();
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar tarjeta", "tarjeta ya usada!");
                }
            }
        }
    }
}
