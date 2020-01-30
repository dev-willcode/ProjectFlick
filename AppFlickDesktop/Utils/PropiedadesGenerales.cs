using AppFlickDesktop.Vistas.Notificaciones;
using Controllers.Controller;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        static ClienteController clienteDTO = new ClienteController();
        static UsuarioController usuarioDTO = new UsuarioController();
        static FuncionesController funcionesDTO = new FuncionesController();
        static TarjetasController tarjetasDTO = new TarjetasController();
        private static Notificar notificar = new Notificar();

        public static ClienteController ClienteDTO { get => clienteDTO; set => clienteDTO = value; }
        public static UsuarioController UsuarioDTO { get => usuarioDTO; set => usuarioDTO = value; }
        public static FuncionesController FuncionesDTO { get => funcionesDTO; set => funcionesDTO = value; }

        public static Notificar Notificar { get => notificar; set => notificar = value; }
        public static TarjetasController TarjetasDTO { get => tarjetasDTO; set => tarjetasDTO = value; }
    }
}
