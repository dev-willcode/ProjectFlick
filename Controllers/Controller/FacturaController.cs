using System;
using System.Data.SqlClient;
using Controllers.DAO;

namespace Controllers.Controller
{
    public class FacturaController : FacturaDAO
    {
        public bool UpdateEstado(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarFacturaEstado"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió actualizar el cliente", ex);
            }
        }
    }
}
