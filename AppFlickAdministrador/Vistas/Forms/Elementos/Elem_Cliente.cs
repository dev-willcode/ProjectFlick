using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Forms;
using AppFlickAdministrador.Vistas.Forms.Elementos;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickAdministrador.Vistas.Init
{
    public partial class Elem_Cliente : UserControl
    {
        public readonly Cliente cliente;

        private VistaClientes_Admin VistaClientes_Admin { get; set; }

        public Elem_Cliente() { }

        public Elem_Cliente(VistaClientes_Admin vistaClientes_Admin, Cliente cliente)
        {
            InitializeComponent();
            rellenarDatos(cliente);
            this.cliente = cliente;
            this.VistaClientes_Admin = vistaClientes_Admin;
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

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            if (PropiedadesGenerales.Notificar.Preguntar("Eliminar", "¿Esta seguro de eliminar?"))
            {
                try
                {
                    PropiedadesGenerales.ClienteController.Delete(cliente.id);
                    PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Se ha eliminado el cliente");
                    VistaClientes_Admin.RellenarClientes();
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Form_Clientes form = new Form_Clientes(VistaClientes_Admin, "Editar Cliente", cliente);
            form.ShowDialog();
        }
    }
}
