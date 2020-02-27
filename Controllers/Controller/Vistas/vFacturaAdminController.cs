using Controllers.Utilidades;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Controller.Vistas
{
    public class vFacturaAdminController
    {
        private UtilsProcedimientos Procedimientos = new UtilsProcedimientos();

        public List<VistaFacturaAdmin> ListarFacturas()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_VistaFacturasClienteAdmin"))
                {
                    return Procedimientos.ListarEntidades<VistaFacturaAdmin>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar Facturas", ex);
            }

        }
    }
}
