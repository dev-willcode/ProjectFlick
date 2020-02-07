using System.Windows.Forms;
using Controllers.Controller;
using Controllers.DAO;
using Entity.Entidades;
using Utils;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class Elem_tarjeta : UserControl
    {
        private Tarjetas tarjetas;

        private TarjetasController TarjetaController = PropiedadesGenerales.TarjetasController;

        private VistaCuenta_Cliente VistaCuenta_Cliente { get; set; }

        public Elem_tarjeta()
        {
            InitializeComponent();
        }

        public Elem_tarjeta(Tarjetas tarjetas)
        {
            InitializeComponent();
            this.tarjetas = tarjetas;
            cargarDatos();
        }

        private void cargarDatos()
        {
            var_tarjeta_tipo.Text = "Tarjeta de " + tarjetas.tarjeta_tipo;
            var_nombre_banco.Text = PropiedadesGenerales.BancoController.Get(tarjetas.tarjeta_banco).banco_nombre;
            var_tarjeta_ano.Text = tarjetas.tarjeta_anio.ToString();
            var_tarjeta_propietario.Text = tarjetas.tarjeta_propietario;
            var_tarjeta_numero.Text = tarjetas.tarjeta_numero_protegido;
            var_mes_dia.Text = tarjetas.tarjeta_mes;
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (res.ToString().Equals("Yes"))
            {
                if (TarjetaController.EliminarTarjeta(tarjetas.id))
                {
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado","Se ha eliminado la tarjeta");
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
