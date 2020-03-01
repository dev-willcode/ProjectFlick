using AppFlickAdministrador.Utils;
using Controllers;
using Entity.Entidades;
using System;
using System.Windows.Forms;
using Utils;

namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    public partial class Form_Empleado : Form
    {
        private readonly Empleado EmpleadoActual;
        private VistaEmpleados_Admin VistaEmpleados_Admin { get; set; }
        public string Accion { get; set; }

        public Form_Empleado(VistaEmpleados_Admin vistaEmpleados_Admin, string titulo)
        {
            Accion = Constantes.accionInsertar;
            inicializarformulario(vistaEmpleados_Admin, titulo);
        }

        public Form_Empleado(VistaEmpleados_Admin vistaEmpleados_Admin,
            string titulo, Empleado empleado)
        {
            Accion = Constantes.accionEditar;
            EmpleadoActual = empleado;
            inicializarformulario(vistaEmpleados_Admin, titulo);
        }

        private void inicializarformulario(VistaEmpleados_Admin vistaEmpleados_Admin, string titulo)
        {
            VistaEmpleados_Admin = vistaEmpleados_Admin;
            Text = titulo;
            InitializeComponent();
            this.CenterToParent();
            if (Accion.Equals(Constantes.accionEditar))
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            txtCedula.Text = EmpleadoActual.empleado_cedula.ToString();
            txtNombre.Text = EmpleadoActual.empleado_nombres.ToString();
            txtApellido.Text = EmpleadoActual.empleado_apellidos.ToString();
            txtTelefono.Text = EmpleadoActual.empleado_telefono.ToString();
            txtEmail.Text = EmpleadoActual.empleado_email.ToString();
            txtDireccion.Text = EmpleadoActual.empleado_direccion.ToString();
            txtUsuario.Text = PropiedadesGenerales.UsuarioController.Get(EmpleadoActual.empleado_usuario).usuario_username;
            txtContraseña.Text = PropiedadesGenerales.UsuarioController.Get(EmpleadoActual.empleado_usuario).usuario_password;
        }

        private bool ValidarCamposEmpleado()
        {
            string errores = "";
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                errores += " - Escriba la cedula" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errores += " - Escriba el nombre" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errores += " - Escriba el apellido" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errores += " - Escriba el telefono" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errores += " - Escriba el email" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errores += " - Escriba la direccion" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errores += " - Escriba un Usuario" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                errores += " - Escriba una Contraseña" + Environment.NewLine;
            }
            return string.IsNullOrEmpty(errores);
        }

        private void NuevoEmpleado()
        {
            if (ValidarCamposEmpleado())
            {
                try
                {
                    Usuario usuario = new Usuario();
                    usuario.usuario_username = txtUsuario.Text;
                    usuario.usuario_password = txtContraseña.Text;

                    if (!PropiedadesGenerales.UsuarioController.UsuarioEstaRepetido(usuario))
                    {
                        Empleado empleado = new Empleado();
                        empleado.empleado_cedula = txtCedula.Text;
                        empleado.empleado_apellidos = txtApellido.Text;
                        empleado.empleado_nombres = txtNombre.Text;
                        empleado.empleado_telefono = txtTelefono.Text;
                        empleado.empleado_email = txtEmail.Text;
                        empleado.empleado_direccion = txtDireccion.Text;
                        empleado.id = PropiedadesGenerales.UsuarioController.RegistrarNuevoEmpleado(usuario, empleado);
                        if (empleado.id != -1)
                        {
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Empleado registrado correctamente");
                            VistaEmpleados_Admin.RellenarEmpleados();
                            Close();
                        }
                    }
                    else
                    {
                        PropiedadesGenerales.Notificar.notificarFallo("Error al registrarse", "el usuario está repetido!");
                    }
                }
                catch (ControllerException ex)
                {

                    PropiedadesGenerales.Notificar.notificarError(ex);
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar empleado", "Ingrese bien los datos");
            }
        }

        private void EditarEmpleado()
        {
            if (ValidarCamposEmpleado())
            {
                Empleado empleadoTemp = generarEmpleado();
                if (!empleadoTemp.Equals(PropiedadesGenerales.EmpleadoActual))
                {
                    try
                    {
                        if (PropiedadesGenerales.EmpleadoController.Update(empleadoTemp))
                        {
                            VistaEmpleados_Admin.RellenarEmpleados();
                            PropiedadesGenerales.Notificar.notificarCorrecto("Completado", "Empleado actualizado");
                            Close();
                        }
                        else
                        {
                            PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar",
                                "Error al actualizar el empleado");
                        }
                    }
                    catch (ControllerException ex)
                    {
                        PropiedadesGenerales.Notificar.notificarError(ex);
                    }
                }
                else
                {
                    PropiedadesGenerales.Notificar.notificarFallo("No se consiguio actualizar", "No cambio ningun dato!");
                }
            }
            else
            {
                PropiedadesGenerales.Notificar.notificarFallo("Error al ingresar empleado", "Ingrese bien los datos");
            }
        }

        private Empleado generarEmpleado()
        {
            Empleado empleado = new Empleado()
            {
                id = EmpleadoActual.id,
                empleado_cedula = txtCedula.Text,
                empleado_apellidos = txtApellido.Text,
                empleado_nombres = txtNombre.Text,
                empleado_telefono = txtTelefono.Text,
                empleado_email = txtEmail.Text,
                empleado_direccion = txtDireccion.Text,
                empleado_usuario = EmpleadoActual.empleado_usuario
            };
            return empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion.Equals(Constantes.accionInsertar))
            {
                NuevoEmpleado();
            }
            else
            {
                EditarEmpleado();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
