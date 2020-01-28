using DataAccess.DAO;
using Entity.Entidades;

namespace Controllers.DTO
{
    public class ClienteDTO
    {
        public ClienteDAO ClienteDAO { get; set; }

        public ClienteDTO()
        {
            ClienteDAO = new ClienteDAO();
        }

        public bool ActualizarCliente(Cliente Entidad)
        {
            return ClienteDAO.Update(Entidad);
        }
    }
}
