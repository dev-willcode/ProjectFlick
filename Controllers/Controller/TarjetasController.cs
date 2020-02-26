using Controllers.DAO;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.Controller
{

    public class TarjetasController : TarjetasDAO
    {
        public List<Tarjetas> listarTarjetas(int idCliente)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BuscarTarjetas"))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    return Procedimientos.ListarEntidades<Tarjetas>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar Tarjetas", ex);
            }
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
