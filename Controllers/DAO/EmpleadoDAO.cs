using System;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class EmpleadoDAO : IDataAccess<Empleado>
    {
        public override int Create(Empleado Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarEmpleado"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarEliminacion<Empleado>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar el  Empleado", ex);
            }
        }

        public override Empleado Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetEmpleado"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Empleado>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener el Empleado", ex);
            }
        }

        public override bool Update(Empleado Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
