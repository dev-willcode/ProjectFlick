using System.Drawing;
using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades.EntidadesPersonalizadas;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms
{
    public partial class Elem_Factura : UserControl
    {
        internal readonly VistaFacturaAdmin factura;

        public Elem_Factura() { }

        public Elem_Factura(VistaFacturaAdmin factura)
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
                var_cliente.Text = factura.cliente_nombres + " " + factura.cliente_apellidos;
                var_titulo.Text = factura.pelicula_titulo;
                var_fecha.Text = factura.factura_fecha_emision.ToShortDateString();
                var_costo_total.Text = (factura.numero_boletos * factura.funcion_precio_boleto).ToString();
                anularBoton();
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void btnImprimir_Click(object sender, System.EventArgs e)
        {
            FormFacturaDatos_Admin facturaDatos = new FormFacturaDatos_Admin();
            facturaDatos.mostrarReporte(factura.id);
            facturaDatos.ShowDialog();

        }

        private void anularBoton()
        {
            if (factura.factura_estado == "ANULADO")
            {
                btnAnular.OnHoverBaseColor = btnAnular.BaseColor = Color.FromArgb(90, 0, 0);
                btnAnular.Enabled = false;
                btnAnular.Text = "ANULADO";
            }
        }
        private void btnAnular_Click(object sender, System.EventArgs e)
        {

            if (factura.factura_estado == "ACTIVO")
            {
                try
                {
                    if (PropiedadesGenerales.FacturaController.UpdateEstado(factura.id))
                    {
                        btnAnular.Text = factura.factura_estado = "ANULADO";
                        btnAnular.OnHoverBaseColor = btnAnular.BaseColor = Color.FromArgb(90, 0, 0);
                        btnAnular.Animated = false;
                        btnAnular.Refresh();
                    }
                }
                catch (ControllerException ex)
                {

                    PropiedadesGenerales.Notificar.notificarError(ex);
                }

            }
        }
    }
}
