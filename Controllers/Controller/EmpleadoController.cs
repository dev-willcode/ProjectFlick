using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class EmpleadoController : EmpleadoDAO
    {
        public List<Empleado> ListarEmpleados()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarEmpleado"))
                {
                    return Procedimientos.ListarEntidades<Empleado>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar los empleados", ex);
            }
        }
    }
}
