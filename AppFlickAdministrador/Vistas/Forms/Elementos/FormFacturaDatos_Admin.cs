using System.Windows.Forms;
using Controllers;
using Controllers.Reportes;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class FormFacturaDatos_Admin : Form
    {

        public FormFacturaDatos_Admin()
        {
            InitializeComponent();
            CenterToParent();
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
                if (reporteController.generarReporte(id))
                {
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
