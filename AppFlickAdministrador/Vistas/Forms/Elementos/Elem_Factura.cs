using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms
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
                var_costo_total.Text = (factura.numero_boletos * factura.funcion_precio_boleto).ToString();
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void btnImprimir_Click(object sender, System.EventArgs e)
        {
            //FormFacturaDatos_Admin facturaDatos = new FormFacturaDatos_Admin();
            //facturaDatos.mostrarReporte(factura.id);
            //facturaDatos.ShowDialog();

        }
    }
}
