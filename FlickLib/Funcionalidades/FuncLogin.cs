using System;
using FlickLib.DAO;
using FlickLib.Entidades;

namespace FlickLib.Funcionalidades
{
    public class FuncLogin
    {
        UsuarioDAO DAOUsuario = new UsuarioDAO();
        ClienteDAO DAOCliente = new ClienteDAO();
        public bool RegistrarCliente(Usuario usuario, Cliente cliente)
        {
            usuario.usuario_perfil = 0; // Perfil nulo para clientes
            int idInsertada = DAOUsuario.Create(usuario); // Crea el usuario y devuelve la id generada.

            // Se creó correctamente el usuario, cree el cliente y asignelo
            if (idInsertada != -1)
            {
                cliente.cliente_usuario = idInsertada;
                // Se creo correctamente el cliente
                if (DAOCliente.Create(cliente) != -1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UsuarioEstaRepetido(Usuario usuario)
        {
            return DAOUsuario.ContarRepetidos(usuario.usuario_username) > 0;
        }

        public Cliente IniciarSesionCliente(Usuario usuario)
        {
            return DAOUsuario.inicioSesion(usuario);
        }
    }
}
