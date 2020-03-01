using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class UsuarioController : UsuarioDAO
    {
        public Cliente IniciarSesionCliente(Usuario usuario)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_IniciarSesionCliente"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@usuario_username",
                        "@usuario_password",
                            },
                        new List<object>() {
                        usuario.usuario_username,
                        usuario.usuario_password,
                        }
                        );
                    return Procedimientos.DevolverEntidad<Cliente>(cmd) as Cliente;
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguío iniciar la sesión", ex);
            }
        }

        public Empleado IniciarSesionEmpleado(Usuario usuario)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_IniciarSesionEmpleado"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@usuario_username",
                        "@usuario_password",
                            },
                        new List<object>() {
                        usuario.usuario_username,
                        usuario.usuario_password,
                        }
                        );
                    return Procedimientos.DevolverEntidad<Empleado>(cmd) as Empleado;
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguío iniciar la sesión", ex);
            }
        }

        public bool UsuarioEstaRepetido(Usuario usuario)
        {
            return ContarRepetidos(usuario.usuario_username) > 0;
        }

        public int RegistrarNuevoCliente(Usuario usuario, Cliente cliente)
        {
            UsuarioDAO UsuarioDAO = new UsuarioDAO();
            ClienteDAO ClienteDAO = new ClienteDAO();
            usuario.usuario_perfil = 0; // Perfil nulo para clientes
            int idInsertada = UsuarioDAO.Create(usuario); // Crea el usuario y devuelve la id generada.

            // Se creó correctamente el usuario, cree el cliente y asignelo
            if (idInsertada != -1)
            {
                cliente.cliente_usuario = idInsertada;
                // Se creo correctamente el cliente
                if (ClienteDAO.Create(cliente) != -1)
                {
                    return idInsertada;
                }
            }
            return -1;
        }

        public int RegistrarNuevoEmpleado(Usuario usuario, Empleado empleado)
        {
            UsuarioDAO UsuarioDAO = new UsuarioDAO();
            EmpleadoDAO EmpleadoDAO = new EmpleadoDAO();
            usuario.usuario_perfil = 0; // Perfil nulo para clientes
            int idInsertada = UsuarioDAO.Create(usuario); // Crea el usuario y devuelve la id generada.

            // Se creó correctamente el usuario, cree el cliente y asignelo
            if (idInsertada != -1)
            {
                empleado.empleado_usuario = idInsertada;
                // Se creo correctamente el cliente
                if (EmpleadoDAO.Create(empleado) != -1)
                {
                    return idInsertada;
                }
            }
            return -1;
        }

        private int ContarRepetidos(string usuario_username)
        {
            string consulta = "SELECT COUNT(*) AS 'count' FROM [Usuario] usuario " +
                    "WHERE usuario.usuario_username = '" + usuario_username + "'";
            using (SqlCommand cmd = Procedimientos.CrearComandoQ(consulta))
            {
                return Procedimientos.retornarConteo(cmd);
            }
        }

        public bool UpdateImagen(int id, byte[] imagen)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarImagenCliente"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() { "@id", "@imagen", },
                        new List<object>() { id, imagen, });
                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguío actualizar la imagen", ex);
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarUsuarios"))
                {
                    return Procedimientos.ListarEntidades<Usuario>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar los usuarios", ex);
            }
        }
    }
}
