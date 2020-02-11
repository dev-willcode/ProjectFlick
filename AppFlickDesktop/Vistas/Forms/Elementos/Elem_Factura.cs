﻿using System.Windows.Forms;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Elem_Factura : UserControl
    {
        internal readonly VistaFacturaFuncion factura;

        public Elem_Factura() { }

        public Elem_Factura(VistaFacturaFuncion factura)
        {
            this.factura = factura;
            InitializeComponent();
            RellenarDatos();
        }

        private void RellenarDatos()
        {
            try
            {
                var_numero_factura.Text = factura.factura_numero;
                var_titulo.Text = factura.pelicula_titulo;
                var_fecha.Text = factura.factura_fecha_emision.ToShortDateString();
                var_hora.Text = factura.horario_inicio.ToString();
                factura.boletos = PropiedadesGenerales.BoletoController.ListarBoletosFuncion(factura.factura_funcion);
                var_cant_boletos.Text = factura.boletos.Count.ToString();
                containerIdioma.Controls.Add(new Elem_idioma_funcion(factura.idioma_abreviatura));
            }
            catch (ControllerException ex)
            {

                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
