using System.Windows.Forms;
using AppFlickCliente.Reports;
using AppFlickCliente.Reports.DataSets;
using Entity.Entidades;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public partial class FormFacturaDatos_Cliente : Form
    {
        private VistaFacturaDatos VistaFactura { get; set; }
        private Empresa Empresa { get; set; }
        public FormFacturaDatos_Cliente()
        {
            InitializeComponent();
        }

        internal void mostrarReporte(int id)
        {
            generarReporte(id);
        }

        private void generarReporte(int id)
        {
            DSFacturaDatos dsFacturaDatos = new DSFacturaDatos();
            VistaFactura = PropiedadesGenerales.VFacturaDatosController.GetDatosFactura(id);
            Empresa = PropiedadesGenerales.EmpresaController.Get(1); // codificar el proceso almacenado y get de empresa
            RPFacturaDatos rPFactura = new RPFacturaDatos();
            //dsFacturaDatos.Empresa.AddEmpresaRow(
            //codificar las propiedades
            //);
            //dsFacturaDatos.Vista_FacturaDatos.AddVista_FacturaDatosRow(
            //codificar las propiedades
            //);
            //dsFacturaDatos.SP_ObtenerBoletosFactura.AddSP_ObtenerBoletosFacturaRow(
            //codificar las propiedades
            //);
            rPFactura.SetDataSource(dsFacturaDatos);
            crystalReportViewer1.ReportSource = rPFactura;
        }
    }
}
