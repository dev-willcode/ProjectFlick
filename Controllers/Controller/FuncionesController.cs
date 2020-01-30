using System.Collections.Generic;
using Controllers.DAO.Vistas;
using Entity.Entidades.Vistas;

namespace Controllers.Controller
{
    public class FuncionesController : IController
    {
        private FuncionesActivasDAO FuncionesActivasDAO { get; set; }

        public FuncionesController()
        {
            FuncionesActivasDAO = new FuncionesActivasDAO();
        }

        public List<FuncionesActivas> ListarFuncionesActivas()
        {
            return FuncionesActivasDAO.GetAll();
        }
    }
}
