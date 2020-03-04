using Controllers.Controller;
using Controllers.Controller.Vistas;
using Reporting.Reportes.CRObjects;
using Reporting.Reportes.DataSets;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Entity.Entidades;
using Entity.Entidades.EntidadesPersonalizadas;
using System.Net;
using System.Net.Mail;
using Controllers;
using System.IO;

namespace Reporting.Reportes
{
    public class ReporteController
    {
        public byte[] byteReporte { get; set; }
        public ReportDocument reporte { get; set; }
        private VistaFacturaDatos vistaFactura { get; set; }
        private Empresa empresa { get; set; }
        private BoletosFactura boletoFactura { get; set; }

        string pdfFile = "D:\\ProyectoPA\\Reportes\\ReporteFactura.pdf";

        public ReporteController()
        {
        }

        public void enviarEmail(ReportDocument reportDocument)
        {
            try
            {
                reportDocument.DataSourceConnections.Clear();
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions pdfRtfWordFormatOptions = new PdfRtfWordFormatOptions();
                diskFileDestinationOptions.DiskFileName = pdfFile;
                exportOptions = reportDocument.ExportOptions;
                exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                exportOptions.FormatOptions = pdfRtfWordFormatOptions;
                reportDocument.Export();

            }
            catch (ControllerException ex)
            {
                throw new ControllerException("No se consiguío exportar el reporte", ex);
            }
        }

        private void smtpCliente()
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.Credentials = new NetworkCredential("cineflick2020@gmail.com", "ProyectoPA20");
                mensaje.To.Add(vistaFactura.cliente_email);
                mensaje.From = new MailAddress("cineflick2020@gmail.com");
                mensaje.Subject = "Factura Electrónica";
                mensaje.Body = "Señor(a): " + vistaFactura.cliente_nombres + " " + vistaFactura.cliente_apellidos;              
                mensaje.Attachments.Add(new Attachment(pdfFile));
                cliente.Send(mensaje);
            }
            catch (ControllerException ex)
            {
                throw new ControllerException("No se consiguío enviar el reporte al Emial", ex);
            }
        }

        /*
         * Método que genera el reporte de una factura, a partir de la id especificada
         * genera un el reporte, que es usado para representar el archivo
         */
        public bool generarReporte(int id)
        {
            try
            {
                DSFacturaDatos dsFacturaDatos = new DSFacturaDatos();
                vistaFactura =  new vFacturaDatosController().GetDatosFactura(id);
                empresa =  new EmpresaController().Get(1);
                boletoFactura = new BoletosFacturaController().getBoletosFactura(id);
                RPFacturaDatos rPFactura = new RPFacturaDatos();

                dsFacturaDatos.Empresa.AddEmpresaRow
                    (
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
                reporte = rPFactura; // añade a la propiedad el doc generado
                return true; // finalizo correct
            }
            catch (ControllerException ex)
            {
                throw new ControllerException("No se consiguío generar el reporte", ex);
            }
        }    
    }
}
