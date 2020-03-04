using System;
using System.Data.SqlClient;
using Controllers.Utilidades;
using Entity.Entidades.EntidadesPersonalizadas;

namespace Controllers.Controller.Vistas
{
    public class vFacturaDatosController
    {
        private UtilsProcedimientos Procedimientos = new UtilsProcedimientos();

        public VistaFacturaDatos GetDatosFactura(int idFactura)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ObtenerFacturaDatos"))
                {
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);
                    return Procedimientos.evaluarObtención<VistaFacturaDatos>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener los datos de la factura", ex);
            }
        }
    }
}
