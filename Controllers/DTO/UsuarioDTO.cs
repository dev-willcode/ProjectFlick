using DataAccess.DAO;
using Entity.Entidades;

namespace Controllers.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDAO UsuarioDAO { get; set; }
        public ClienteDAO ClienteDAO { get; set; }
        
        public UsuarioDTO()
        {
            UsuarioDAO = new UsuarioDAO();
            ClienteDAO = new ClienteDAO();
        }

        public Cliente IniciarSesion(Usuario usuario)
        {
            return UsuarioDAO.inicioSesion(usuario);
        }

        public bool UsuarioEstaRepetido(Usuario usuario)
        {
            return UsuarioDAO.ContarRepetidos(usuario.usuario_username) > 0;
        }

        public bool RegistrarNuevoCliente(Usuario usuario, Cliente cliente)
        {
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
    }
}
