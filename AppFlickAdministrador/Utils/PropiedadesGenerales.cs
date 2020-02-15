using AppFlickAdministrador.Vistas.Notificaciones;
using Controllers.Controller;
using Entity.Entidades;

namespace Utils
{
    public static class PropiedadesGenerales
    {
        public static Empleado EmpleadoActual { get; set; }

        private static Notificar notificar = new Notificar();
        private static EmpleadoController empleadoController = new EmpleadoController();
        private static UsuarioController usuarioController = new UsuarioController();


        public static Notificar Notificar { get => notificar; set => notificar = value; }
        public static EmpleadoController EmpleadoController { get => empleadoController; set => empleadoController = value; }
        public static UsuarioController UsuarioController { get => usuarioController; set => usuarioController = value; }
    }
}
