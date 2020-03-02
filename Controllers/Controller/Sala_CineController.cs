using Controllers.DAO;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.Controller
{
    public class Sala_CineController : Sala_CineDAO
    {
        public List<Sala_Cine> ListarSalas()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarSala"))
                {
                    return Procedimientos.ListarEntidades<Sala_Cine>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las salas", ex);
            }
        }
    }
}
