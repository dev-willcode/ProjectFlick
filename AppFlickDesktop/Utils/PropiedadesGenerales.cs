using AppFlickDesktop.Vistas.Notificaciones;
using Controllers.Controller;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        private static ClienteController clienteController = new ClienteController();
        private static UsuarioController usuarioController = new UsuarioController();
        private static FuncionesController funcionesController = new FuncionesController();
        private static TarjetasController tarjetasController = new TarjetasController();
        private static Notificar notificar = new Notificar();

        public static ClienteController ClienteController { get => clienteController; set => clienteController = value; }
        public static UsuarioController UsuarioController { get => usuarioController; set => usuarioController = value; }
        public static FuncionesController FuncionesController { get => funcionesController; set => funcionesController = value; }
        public static TarjetasController TarjetasController { get => tarjetasController; set => tarjetasController = value; }
        public static Notificar Notificar { get => notificar; set => notificar = value; }
    }
}
