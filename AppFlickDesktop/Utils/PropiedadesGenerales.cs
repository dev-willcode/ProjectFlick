using AppFlickDesktop.Vistas.Notificaciones;
using Controllers.Controller;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        private static ClienteController clienteController = new ClienteController();
        private static UsuarioController usuarioController = new UsuarioController();
        private static FuncionesController funcionesController = new FuncionesController();
        private static PeliculaController peliculaController = new PeliculaController();
        private static TarjetasController tarjetasController = new TarjetasController();
        private static BoletoController boletoController = new BoletoController();
        private static CategoriaController categoriaController = new CategoriaController();
        private static IdiomaController idiomaController = new IdiomaController();
        private static Notificar notificar = new Notificar();

        public static ClienteController ClienteController { get => clienteController; set => clienteController = value; }
        public static UsuarioController UsuarioController { get => usuarioController; set => usuarioController = value; }
        public static FuncionesController FuncionesController { get => funcionesController; set => funcionesController = value; }
        public static PeliculaController PeliculaController { get => peliculaController; set => peliculaController = value; }
        public static TarjetasController TarjetasController { get => tarjetasController; set => tarjetasController = value; }
        public static BoletoController BoletoController { get => boletoController; set => boletoController = value; }       
        public static Notificar Notificar { get => notificar; set => notificar = value; }
        public static CategoriaController CategoriaController { get => categoriaController; set => categoriaController = value; }
        public static IdiomaController IdiomaController { get => idiomaController; set => idiomaController = value; }
    }
}
