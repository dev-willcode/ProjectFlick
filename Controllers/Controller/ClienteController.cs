using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class ClienteController : IController
    {
        public ClienteDAO ClienteDAO { get; set; }

        public ClienteController()
        {
            ClienteDAO = new ClienteDAO();
        }

        public bool ActualizarCliente(Cliente Entidad)
        {
            return ClienteDAO.Update(Entidad);
        }
    }
}
