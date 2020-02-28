using System.Windows.Forms;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Cliente : UserControl
    {
        public readonly Cliente cliente;

        public Elem_Cliente() { }

        public Elem_Cliente(Cliente cliente)
        {
            InitializeComponent();
            rellenarDatos(cliente);
            this.cliente = cliente;
        }

        private void rellenarDatos(Cliente cliente)
        {
            try
            {
                var_cedula.Text = cliente.cliente_cedula;
                var_nombre_completo.Text = cliente.cliente_apellidos + " " + cliente.cliente_nombres;
                var_direccion.Text = cliente.cliente_direccion;
                var_email.Text = cliente.cliente_email;
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
