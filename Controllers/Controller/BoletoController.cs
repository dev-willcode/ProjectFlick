using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO.Vistas;
using Entity.Entidades;

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

        public List<Boleto> listarBoletosFuncion(int id)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BoletosFuncion"))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Procedimientos.ListarEntidades<Boleto>(cmd);
            }
        }
    }
}
