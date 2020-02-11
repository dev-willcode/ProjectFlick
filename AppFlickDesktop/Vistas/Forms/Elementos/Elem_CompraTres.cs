using System;
using System.Collections.Generic;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
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
            try
            {
                Tarjetas tarjeta = new Tarjetas();
                List<Tarjetas> lista = PropiedadesGenerales.TarjetasController
                    .listarTarjetas(PropiedadesGenerales.ClienteActual.id);
                tarjeta.tarjeta_numero_protegido = "Seleccione...";
                lista.Insert(0, tarjeta);
                comboTarjetas.DataSource = lista;
                comboTarjetas.DisplayMember = "tarjeta_numero_protegido";
                comboTarjetas.ValueMember = "id";
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        internal void ActualizarInformacionCompra()
        {
            var_titulo.Text = VistaFunciones.pelicula_titulo;
            var_sala.Text = VistaFunciones.sala_nombre;
            var_fecha.Text = "Fecha: " + VistaFunciones.funcion_fecha_evento.ToShortDateString();
            var_hora.Text = "Hora: " + VistaFunciones.horario_inicio.ToString();
            var_cantBoletos.Text = "Cant. Boletos: " + FormPadre.CantBoletosAComprar;
            containerIdioma.Controls.Add(new Elem_idioma_funcion(VistaFunciones.idioma_abreviatura));
            var_asientos.Text = FormPadre.AsientosSeleccionados;
            var_precioTotal.Text = "Total a pagar: $" + FormPadre.PrecioTotal;
            if (VistaFunciones.pelicula_imagen != null)
            {
                var_imagen_pelicula.Image = Utils.UtilsProcedimientos.generarImagen(VistaFunciones.pelicula_imagen);
            }
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
            }
            else
            {
                {
                    // Generar los boletos aquí
                    PropiedadesGenerales.Notificar.notificarCorrecto("Éxito", "Ha completado correctamente su compra, se ha generado una factura asociada a la compra.");
                    FormPadre.Close();
                }
            }
        }
    }
}
