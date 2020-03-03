using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using AppFlickCliente.Reports;
using AppFlickCliente.Reports.DataSets;
using Controllers;
using Controllers.Reportes;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Entity.Entidades;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public partial class FormFacturaDatos_Cliente : Form
    {
        private VistaFacturaDatos vistaFactura { get; set; }
        private Empresa empresa { get; set; }
        private BoletosFactura boletoFactura { get; set; }

        string pdfFile = "D:\\ProyectoPA\\Reportes\\ReporteFactura.pdf";

        public FormFacturaDatos_Cliente()
        {
            InitializeComponent();
        }

        public void mostrarReporte(int id)
        {
            generarReporte(id);
        }

        private void enviarEmail(ReportDocument reportDocument)
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
                smtpCliente();
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
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
                PropiedadesGenerales.Notificar.notificarCorrecto("Factura enviada..", "Factura enviada al correo electrónico");
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void generarReporte(int id)
        {
            try
            {
                ReporteController reporteController = new ReporteController();
                if (reporteController.generarReporte(id)) { 
                    crystalReportViewer1.ReportSource = reporteController.reporte;
                    enviarEmail(reporteController.reporte);
                }
            }
            catch (ControllerException ex)
            {

                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
