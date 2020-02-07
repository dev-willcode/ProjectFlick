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

        public bool RegistrarTarjeta(Tarjetas tarjeta)
        {
            return new TarjetasDAO().Create(tarjeta) != 0;
        }

        public bool TarjetaRepetida(Tarjetas tarjeta)
        {
            return ContarRepetidos(tarjeta.tarjeta_numero) > 0;
        }

        private int ContarRepetidos(string tarjeta_numero)
        {
            string consulta = "SELECT COUNT(*) AS 'count' FROM[Tarjetas] " +
                    "WHERE Tarjetas.tarjeta_numero = '" + tarjeta_numero + "'";
            using (SqlCommand cmd = Procedimientos.CrearComandoQ(consulta))
            {
                return Procedimientos.retornarConteo(cmd);
            }
        }
    }
}
