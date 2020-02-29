using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class ClienteController : ClienteDAO
    {
        public List<Cliente> ListarClientes()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarCliente"))
                {
                    return Procedimientos.ListarEntidades<Cliente>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar los clientes", ex);
            }
        }
    }
}
