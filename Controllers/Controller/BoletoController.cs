using Controllers.DAO.Vistas;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Controller
{
    public class BoletoController : BoletoDAO
    {
        public List<Boleto> listarBoletos(int idCliente)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BoletosCliente"))
            {
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                return Procedimientos.ListarEntidades<Boleto>(cmd);
            }
        }
    }
}
