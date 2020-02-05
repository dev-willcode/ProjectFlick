using System.Windows.Forms;
using Entity.Entidades;
using Utils;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class Elem_tarjeta : UserControl
    {
        private Tarjetas tarjetas;

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
            var_nombre_banco.Text = PropiedadesGenerales.BancoController.Get(tarjetas.id).banco_nombre;
            var_tarjeta_ano.Text = tarjetas.tarjeta_ano.ToString();
            var_tarjeta_propietario.Text = tarjetas.tarjeta_propietario;
            var_tarjeta_numero.Text = "XXX XXXX XXXX " + tarjetas.tarjeta_numero
                .Substring(tarjetas.tarjeta_numero.Length - 4);
            var_mes_dia.Text = tarjetas.tarjeta_mes + "/" + tarjetas.tarjeta_dia;
        }
    }
}
