using AppFlickCliente.Vistas.Notificaciones;
using Controllers.Controller;
using Entity.Entidades;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        private static ClienteController clienteController = new ClienteController();
        private static UsuarioController usuarioController = new UsuarioController();
        private static FuncionesController funcionesController = new FuncionesController();
        private static TarjetasController tarjetasController = new TarjetasController();
        private static BoletoController boletoController = new BoletoController();
        private static BancoController bancoController = new BancoController();
        private static FacturaController facturaController = new FacturaController();
        private static Notificar notificar = new Notificar();

        public static ClienteController ClienteController { get => clienteController; set => clienteController = value; }
        public static UsuarioController UsuarioController { get => usuarioController; set => usuarioController = value; }
        public static FuncionesController FuncionesController { get => funcionesController; set => funcionesController = value; }
        public static TarjetasController TarjetasController { get => tarjetasController; set => tarjetasController = value; }
        public static BoletoController BoletoController { get => boletoController; set => boletoController = value; }
        public static Notificar Notificar { get => notificar; set => notificar = value; }
        public static Cliente ClienteActual { get; internal set; }
        public static BancoController BancoController { get => bancoController; set => bancoController = value; }
        public static FacturaController FacturaController { get => facturaController; set => facturaController = value; }
    }
}
