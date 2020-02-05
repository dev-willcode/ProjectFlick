using System;
using System.Collections.Generic;
using Entity.Entidades;
using Utils;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Elem_CompraTres : Elem_Compra
    {
        public Elem_CompraTres()
            : base()
        {
            InitializeComponent();
        }

        public Elem_CompraTres(Form_Comprar form)
            : base(form)
        {
            FormPadre = form;
            InitializeComponent();
            cargarTarjetas();
        }

        private void cargarTarjetas()
        {
            Tarjetas tarjeta = new Tarjetas();
            List<Tarjetas> lista = PropiedadesGenerales.TarjetasController
                .listarTarjetas(PropiedadesGenerales.ClienteActual.id);
            tarjeta.tarjeta_numero = "Seleccione...";
//            tarjeta.tarjeta_nombre_banco = "";
            lista.Insert(0, tarjeta);
            comboTarjetas.DataSource = lista;
            comboTarjetas.DisplayMember = "tarjeta_numero";
            comboTarjetas.ValueMember = "tarjeta_nombre_banco";
        }

        internal void ActualizarInformacionCompra()
        {
            var_titulo.Text = CFuncionesController.Pelicula.pelicula_titulo;
            var_sala.Text = CFuncionesController.Sala_Cine.sala_nombre;
            var_fecha.Text = "Fecha: " + CFuncionesController.Funcion.funcion_fecha_evento.ToShortDateString();
            var_hora.Text = "Hora: " + CFuncionesController.Horarios.horario_inicio.ToString();
            var_cantBoletos.Text = "Cant. Boletos: " + FormPadre.CantBoletosAComprar;
            containerIdioma.Controls.Add(new Elem_idioma_funcion(CFuncionesController.Idioma));
            var_asientos.Text = FormPadre.AsientosSeleccionados;
            var_precioTotal.Text = "Total a pagar: $" + FormPadre.PrecioTotal;

        }

        private void comboTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtBanco.Text = ((Tarjetas)comboTarjetas.Items[comboTarjetas.SelectedIndex]).tarjeta_nombre_banco;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comboTarjetas.SelectedIndex == 0)
            {
                PropiedadesGenerales.Notificar.notificarFallo("Eror al ingresar datos bancarios", "Seleccione una tarjeta primero");
            }
            else if (txtCCV.Text.Length < 3)
            {
                PropiedadesGenerales.Notificar.notificarFallo("Eror al ingresar datos bancarios", "Codigo de seguridad CCV incorrecto");
            } else
            {
                {
                    // Generar los boletos aquí
                    PropiedadesGenerales.Notificar.notificarWindows("Éxito", "Ha completado correctamente su compra, se ha generado una factura asociada a la compra.");
                    FormPadre.Close();
                }
            }
        }

        private Boleto generarBoleto()
        {
            return null;
        }
    }
}
