using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppFlickCliente.Vistas.Forms.Elementos;
using AppFlickCliente.Vistas.Init;
using Controllers;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;
using Utils;

namespace AppFlickCliente.Vistas.Forms
{
    public partial class VistaCuenta_Cliente : Vistas
    {
        private PanelScrollHelper scroll;
        public VistaCuenta_Cliente() { }
        public VistaCuenta_Cliente(Dashboard dashboard)
            : base(dashboard)
        {
            InitializeComponent();
            PropiedadesScroll();
            rellenarTarjetas();
            cargarDatos();
        }

        private void anadirTarjetaVacia()
        {
            Elem_tarjeta_vacia tarjeta_Vacia = new Elem_tarjeta_vacia(this);
            panelTarjetas.Controls.Add(tarjeta_Vacia);
            tarjeta_Vacia.Dock = DockStyle.Top;
        }

        private void cargarDatos()
        {
            txtCedula_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_cedula.ToString();
            txtApellidos_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_apellidos.ToString();
            txtNombres_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_nombres.ToString();
            txtTelefono_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_telefono.ToString();
            txtEmail_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_email.ToString();
            txtDireccion_usuario.Text = PropiedadesGenerales.ClienteActual.cliente_direccion.ToString();
            if (PropiedadesGenerales.ClienteActual.cliente_imagen != null)
            {
                var_imagen_usuario.Image = Utils.UtilsProcedimientos.generarImagen(PropiedadesGenerales.ClienteActual.cliente_imagen);
            }

        }

        private void PropiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelTarjetas, scrollBar, true);
            scroll.UpdateScrollBar();
        }
        public void rellenarTarjetas()
        {
            panelTarjetas.Controls.Clear();
            List<Tarjetas> listaTarjeta = PropiedadesGenerales.TarjetasController
                .listarTarjetas(PropiedadesGenerales.ClienteActual.id);
            listaTarjeta.ForEach(tarjeta =>
            {
                Elem_tarjeta elemento = new Elem_tarjeta(this, tarjeta);
                panelTarjetas.Controls.Add(elemento);
                elemento.Dock = DockStyle.Top;
            });
            anadirTarjetaVacia();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            Cliente clienteTemp = generarCliente();
            if (!clienteTemp.Equals(PropiedadesGenerales.ClienteActual))
            {
                try
                {
                    if (PropiedadesGenerales.ClienteController.Update(clienteTemp))
                    {
                        PropiedadesGenerales.ClienteActual = clienteTemp;
                        Dashboard.cargarDatos();
                        PropiedadesGenerales.Notificar.notificarCorrecto("Actualizado",
                            "Informacion personal actualizada correctamente");
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                            "Error al actualizar su informacion personal");
                    }
                }
                catch (ControllerException ex)
                {
                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                        "No cambio ningun dato!");
            }
        }

        private Cliente generarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.id = PropiedadesGenerales.ClienteActual.id;
            cliente.cliente_cedula = txtCedula_usuario.Text;
            cliente.cliente_apellidos = txtApellidos_usuario.Text;
            cliente.cliente_nombres = txtNombres_usuario.Text;
            cliente.cliente_telefono = txtTelefono_usuario.Text;
            cliente.cliente_email = txtEmail_usuario.Text;
            cliente.cliente_direccion = txtDireccion_usuario.Text;
            cliente.cliente_usuario = PropiedadesGenerales.ClienteActual.cliente_usuario;
            cliente.cliente_imagen = PropiedadesGenerales.ClienteActual.cliente_imagen;
            return cliente;

        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectorArchivo.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(SelectorArchivo.FileName);
                    byte[] bitarray = Utils.UtilsProcedimientos.ImageToByteArray(img);
                    if (PropiedadesGenerales.UsuarioController.UpdateImagen(
                        PropiedadesGenerales.ClienteActual.id, bitarray))
                    {
                        PropiedadesGenerales.Notificar.notificarCorrecto("correcto", "actualizado correcto");
                        PropiedadesGenerales.ClienteActual.cliente_imagen = bitarray;
                        Dashboard.cargarDatos();
                        var_imagen_usuario.Image = img;
                    }

                }
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }
    }
}
