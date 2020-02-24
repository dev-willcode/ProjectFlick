﻿using AppFlickAdministrador.Reports;
using AppFlickAdministrador.Reports.DataSets;
using Controllers;
using Entity.Entidades;
using Entity.Entidades.EntidadesPersonalizadas;
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
    public partial class FormFacturaDatos_Admin : Form
    {

        private VistaFacturaDatos vistaFactura { get; set; }
        private Empresa empresa { get; set; }
        private BoletosFactura boletoFactura { get; set; }

        public FormFacturaDatos_Admin()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public void mostrarReporte(int id)
        {
            generarReporte(id);
        }

        private void generarReporte(int id)
        {
            try
            {
                DSFacturaDatos dsFacturaDatos = new DSFacturaDatos();
                vistaFactura = PropiedadesGenerales.VFacturaDatosController.GetDatosFactura(id);
                empresa = PropiedadesGenerales.EmpresaController.Get(1);
                boletoFactura = PropiedadesGenerales.BoletosFacturaController.getBoletosFactura(id);
                RPFacturaDatos rPFactura = new RPFacturaDatos();

                dsFacturaDatos.Empresa.AddEmpresaRow
                    (
                    empresa.id,
                    empresa.empresa_razon_social,
                    empresa.empresa_numero_contribuyente,
                    empresa.empresa_numero_autorizacion,
                    empresa.empresa_direccion,
                    empresa.empresa_telefono,
                    empresa.empresa_email,
                    empresa.empresa_website,
                    empresa.empresa_ambiente,
                    empresa.empresa_contabilidad
                    );
                dsFacturaDatos.Vista_FacturaDatos.AddVista_FacturaDatosRow(
                    vistaFactura.id,
                    vistaFactura.cliente_cedula,
                    vistaFactura.cliente_apellidos,
                    vistaFactura.cliente_nombres,
                    vistaFactura.cliente_telefono,
                    vistaFactura.cliente_email,
                    vistaFactura.cliente_direccion,
                    vistaFactura.factura_numero,
                    vistaFactura.factura_fecha_emision,
                    vistaFactura.factura_metodo_pago,
                    vistaFactura.funcion_fecha_evento,
                    vistaFactura.funcion_precio_boleto,
                    vistaFactura.sala_nombre,
                    vistaFactura.horario_inicio,
                    vistaFactura.idioma_abreviatura,
                    vistaFactura.pelicula_titulo,
                    vistaFactura.pelicula_tipo_censura,
                    vistaFactura.pelicula_duracion
                );
                dsFacturaDatos.SP_ObtenerBoletosFactura.AddSP_ObtenerBoletosFacturaRow(
                    boletoFactura.cantidad,
                    boletoFactura.asientos,
                    boletoFactura.concepto,
                    boletoFactura.precio_unitario,
                    boletoFactura.importe,
                    boletoFactura.iva,
                    boletoFactura.total
                );
                rPFactura.SetDataSource(dsFacturaDatos);
                crystalReportViewer1.ReportSource = rPFactura;
            }
            catch (ControllerException ex)
            {

                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
