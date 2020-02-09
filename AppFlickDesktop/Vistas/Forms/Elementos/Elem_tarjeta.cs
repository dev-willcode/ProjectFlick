using System.Windows.Forms;
using Controllers.Controller;
using Entity.Entidades;
using Utils;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Elem_tarjeta : UserControl
    {
        private Tarjetas Tarjeta { get; set; }

        private TarjetasController TarjetaController = PropiedadesGenerales.TarjetasController;

        private VistaCuenta_Cliente VistaCuenta_Cliente { get; set; }

        public Elem_tarjeta() { }

        public Elem_tarjeta(VistaCuenta_Cliente vistaCuenta_Cliente, Tarjetas tarjetas)
        {
            Tarjeta = tarjetas;
            VistaCuenta_Cliente = vistaCuenta_Cliente;
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            var_tarjeta_tipo.Text = "Tarjeta de " + Tarjeta.tarjeta_tipo;
            var_nombre_banco.Text = PropiedadesGenerales.BancoController.Get(Tarjeta.tarjeta_banco).banco_nombre;
            var_tarjeta_ano.Text = Tarjeta.tarjeta_anio.ToString();
            var_tarjeta_propietario.Text = Tarjeta.tarjeta_propietario;
            var_tarjeta_numero.Text = Tarjeta.tarjeta_numero_protegido;
            var_mes_dia.Text = Tarjeta.tarjeta_mes;
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGenerales.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                if (TarjetaController.EliminarTarjeta(Tarjeta.id))
                {
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Se ha eliminado la tarjeta");
                    VistaCuenta_Cliente.rellenarTarjetas();
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("Eliminación Cancelada", "No se ha borrado la tarjeta");
                }
            }
        }
    }
}
