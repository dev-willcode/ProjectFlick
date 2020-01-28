using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFlickDesktop.Vistas.Notificaciones;
using Controllers.DTO;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        static ClienteDTO clienteDTO = new ClienteDTO();
        static UsuarioDTO usuarioDTO = new UsuarioDTO();
        static FuncionesDTO funcionesDTO = new FuncionesDTO();
        private static Notificar notificar = new Notificar();

        public static ClienteDTO ClienteDTO { get => clienteDTO; set => clienteDTO = value; }
        public static UsuarioDTO UsuarioDTO { get => usuarioDTO; set => usuarioDTO = value; }
        public static FuncionesDTO FuncionesDTO { get => funcionesDTO; set => funcionesDTO = value; }

        public static Notificar Notificar { get => notificar; set => notificar = value; }
    }
}
