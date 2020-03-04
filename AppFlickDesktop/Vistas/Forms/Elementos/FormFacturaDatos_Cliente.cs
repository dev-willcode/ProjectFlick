using System.Windows.Forms;
using Controllers;
using Reporting.Reportes;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public partial class FormFacturaDatos_Cliente : Form
    {
        public FormFacturaDatos_Cliente()
        {
            InitializeComponent();
        }

        public void mostrarReporte(int id)
        {
            generarReporte(id);
        }

        private void generarReporte(int id)
        {
            try
            {
                ReporteController reporteController = new ReporteController();
                if (reporteController.generarReporte(id)) { 
                    crystalReportViewer1.ReportSource = reporteController.reporte;
                    reporteController.enviarEmail(reporteController.reporte);
                }
            }
            catch (ControllerException ex)
            {

                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
