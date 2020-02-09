using System.Windows.Forms;
using Entity.Entidades;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class Elem_boleto : UserControl
    {

        private Boleto boleto;

        public Elem_boleto()
        {
            InitializeComponent();
        }

        public Elem_boleto(Boleto boleto)
        {
            InitializeComponent();
            this.boleto = boleto;
            cargarDatos();
        }

        private void cargarDatos()
        {
            var_boleto_asiento.Text = boleto.boleto_asiento;
            var_costo_boleto.Text = boleto.boleto_medio_compra;
        }
    }
}
