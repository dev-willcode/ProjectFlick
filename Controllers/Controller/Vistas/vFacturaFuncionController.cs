using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.Utilidades;
using Entity.Entidades.EntidadesPersonalizadas;

namespace Controllers.Controller.Vistas
{
    public class vFacturaFuncionController
    {
        private UtilsProcedimientos Procedimientos = new UtilsProcedimientos();

        public List<VistaFacturaFuncion> ListarFacturas(int idCliente)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_VistaFacturasCliente"))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    return Procedimientos.ListarEntidades<VistaFacturaFuncion>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió listar Facturas", ex);
            }

        }
    }
}
