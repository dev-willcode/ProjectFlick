using AppFlickCliente.Vistas.Notificaciones;
using Controllers.Controller;
using Controllers.Controller.Vistas;
using Entity.Entidades;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        public static Cliente ClienteActual { get; internal set; }

        private static Notificar notificar = new Notificar();
        private static ClienteController clienteController = new ClienteController();
        private static UsuarioController usuarioController = new UsuarioController();
        private static FuncionesController funcionesController = new FuncionesController();
        private static TarjetasController tarjetasController = new TarjetasController();
        private static BoletoController boletoController = new BoletoController();
        private static BancoController bancoController = new BancoController();
        private static FacturaController facturaController = new FacturaController();
        private static CategoriaController categoriaController = new CategoriaController();
        private static EmpresaController empresaController = new EmpresaController();

        private static BoletosFacturaController boletosFacturaController = new BoletosFacturaController();
        private static vFuncionesController vFuncionesController = new vFuncionesController();
        private static vFacturaFuncionController vFacturaFuncionController = new vFacturaFuncionController();
        private static vFacturaDatosController vFacturaDatosController = new vFacturaDatosController();

        public static Notificar Notificar { get => notificar; set => notificar = value; }
        public static ClienteController ClienteController { get => clienteController; set => clienteController = value; }
        public static UsuarioController UsuarioController { get => usuarioController; set => usuarioController = value; }
        public static FuncionesController FuncionesController { get => funcionesController; set => funcionesController = value; }
        public static TarjetasController TarjetasController { get => tarjetasController; set => tarjetasController = value; }
        public static BoletoController BoletoController { get => boletoController; set => boletoController = value; }
        public static BancoController BancoController { get => bancoController; set => bancoController = value; }
        public static FacturaController FacturaController { get => facturaController; set => facturaController = value; }
        public static CategoriaController CategoriaController { get => categoriaController; set => categoriaController = value; }
        public static vFuncionesController VFuncionesController { get => vFuncionesController; set => vFuncionesController = value; }
        public static vFacturaFuncionController VFacturaFuncionController { get => vFacturaFuncionController; set => vFacturaFuncionController = value; }
        public static vFacturaDatosController VFacturaDatosController { get => vFacturaDatosController; set => vFacturaDatosController = value; }
        public static EmpresaController EmpresaController { get => empresaController; set => empresaController = value; }
        public static BoletosFacturaController BoletosFacturaController { get => boletosFacturaController; set => boletosFacturaController = value; }
    }
}
