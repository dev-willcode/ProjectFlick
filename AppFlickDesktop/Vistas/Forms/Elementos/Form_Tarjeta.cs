﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers;
using Controllers.Controller;
using Entity.Entidades;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
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
            try
            {
                List<Banco> lista = PropiedadesGenerales.BancoController.ListarBancosActivos();
                comboBancos.DataSource = lista;
                comboBancos.DisplayMember = "banco_nombre";
                comboBancos.ValueMember = "id";
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
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
                    tarjeta.tarjeta_cliente = PropiedadesGenerales.ClienteActual.id;
                    tarjeta.tarjeta_banco = int.Parse(comboBancos.SelectedValue.ToString());
                    tarjeta.tarjeta_anio = comboAnio.SelectedValue.ToString();
                    tarjeta.tarjeta_mes = comboMes.SelectedValue.ToString();
                    tarjeta.tarjeta_tipo = comboTipo.Text;
                    tarjeta.tarjeta_ccv = txtCCV.Text;
                    tarjeta.tarjeta_propietario = txtPropietario.Text;
                    tarjeta.tarjeta_numero = txtNumeroTarjeta.Text;
                    if (txtNumeroTarjeta.Text.Length > 15 && txtCCV.Text.Length > 2)
                    {
                        try
                        {
                            TarjetaController.Create(tarjeta);
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Tarjeta ingresada");
                            VistaCuenta_Cliente.rellenarTarjetas();
                            Close();
                        }
                        catch (ControllerException ex)
                        {

                            PropiedadesGenerales.Notificar.notificarError(ex);
                        }
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar tarjeta", "tarjeta ya usada!");
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Faltan datos", "Complete todos los campos!");
                }
            }
        }

        private void txtNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
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

        private void txtCCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
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
