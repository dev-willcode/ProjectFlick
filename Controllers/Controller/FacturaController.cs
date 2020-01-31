using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class FacturaController : FacturaDAO
    {
        public List<Factura> ListarFacturas(int idCliente)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_FacturasCliente"))
            {
                cmd.Parameters.AddWithValue("@id", idCliente);
                return Procedimientos.ListarEntidades<Factura>(cmd);
            }
        }
    }
}
