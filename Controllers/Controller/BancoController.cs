using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class BancoController : BancoDAO
    {
        public List<Banco> ListarBancosActivos()
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BancosActivos"))
            {
                return Procedimientos.ListarEntidades<Banco>(cmd);
            }
        }
    }
}
