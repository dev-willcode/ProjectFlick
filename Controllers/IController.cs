using Controllers.Utilidades;

namespace Controllers.Controller
{
    public abstract class IController
    {
        public UtilsProcedimientos Procedimientos { get; set; }

        protected IController()
        {
            Procedimientos = new UtilsProcedimientos();
        }
    }
}
