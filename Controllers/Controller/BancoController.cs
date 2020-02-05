using Controllers.DAO;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
