using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{

    public class TarjetasController : TarjetasDAO
    {
        public List<Tarjetas> listarTarjetas(int idCliente)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BuscarTarjetas"))
            {
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                return Procedimientos.ListarEntidades<Tarjetas>(cmd);
            }
        }
    }
}
