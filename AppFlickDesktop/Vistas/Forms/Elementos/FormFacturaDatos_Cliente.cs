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
        private BoletosFactura BoletoFactura { get; set; }

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
            Empresa = PropiedadesGenerales.EmpresaController.Get(id);
            BoletoFactura = PropiedadesGenerales.BoletosFacturaController.getBoletosFactura(id);
            RPFacturaDatos rPFactura = new RPFacturaDatos();
            dsFacturaDatos.Empresa.AddEmpresaRow(
                Empresa.id,
                Empresa.empresa_razon_social,
                Empresa.empresa_numero_contribuyente,
                Empresa.empresa_numero_autorizacion,
                Empresa.empresa_direccion,
                Empresa.empresa_telefono,
                Empresa.empresa_email,
                Empresa.empresa_website,
                Empresa.empresa_ambiente,
                Empresa.empresa_contabilidad
            );
            dsFacturaDatos.Vista_FacturaDatos.AddVista_FacturaDatosRow(
                VistaFactura.id,
                VistaFactura.cliente_cedula,
                VistaFactura.cliente_apellidos,
                VistaFactura.cliente_nombres,
                VistaFactura.cliente_telefono,
                VistaFactura.cliente_email,
                VistaFactura.cliente_direccion,
                VistaFactura.factura_numero,
                VistaFactura.factura_fecha_emision,
                VistaFactura.factura_metodo_pago,
                VistaFactura.funcion_fecha_evento,
                VistaFactura.funcion_precio_boleto,
                VistaFactura.sala_nombre,
                VistaFactura.horario_inicio,
                VistaFactura.idioma_abreviatura,
                VistaFactura.pelicula_titulo,
                VistaFactura.pelicula_tipo_censura,
                VistaFactura.pelicula_duracion
            );
            dsFacturaDatos.SP_ObtenerBoletosFactura.AddSP_ObtenerBoletosFacturaRow(
                BoletoFactura.cantidad,
                BoletoFactura.asientos,
                BoletoFactura.concepto,
                BoletoFactura.precio_unitario,
                BoletoFactura.importe,
                BoletoFactura.iva,
                BoletoFactura.total
            );
            rPFactura.SetDataSource(dsFacturaDatos);
            crystalReportViewer1.ReportSource = rPFactura;
        }
    }
}
