using System;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades.EntidadesPersonalizadas;

namespace Controllers.Controller.Vistas
{
    public class BoletosFacturaController : BoletosFacturaDAO
    {
        public BoletosFactura getBoletosFactura(int idFactura)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ObtenerBoletosFactura"))
                {
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);
                    return Procedimientos.evaluarObtención<BoletosFactura>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener los Boletos de la Factura", ex);
            }
        }
    }
}
