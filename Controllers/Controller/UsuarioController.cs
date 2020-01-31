using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class UsuarioController : UsuarioDAO
    {
        public Cliente IniciarSesion(Usuario usuario)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_IniciarSesion"))
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

        public bool UsuarioEstaRepetido(Usuario usuario)
        {
            return ContarRepetidos(usuario.usuario_username) > 0;
        }

        public bool RegistrarNuevoCliente(Usuario usuario, Cliente cliente)
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
                    return true;
                }
            }
            return false;
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
    }
}
