using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class EmpleadoDAO : IDataAccess<Empleado>
    {
        public override int Create(Empleado Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearEmpleado"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@empleado_nombres",
                        "@empleado_cedula",
                        "@empleado_apellidos",
                        "@empleado_telefono",
                        "@empleado_email",
                        "@empleado_direccion",
                        "@empleado_usuario" },
                        new List<object>() {
                        Entidad.empleado_nombres,
                        Entidad.empleado_cedula,
                        Entidad.empleado_apellidos,
                        Entidad.empleado_telefono,
                        Entidad.empleado_email,
                        Entidad.empleado_direccion,
                        Entidad.empleado_usuario }
                        );

                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió crear un empleado", ex);
            }
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
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarEmpleado"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@id",
                        "@empleado_nombres",
                        "@empleado_cedula",
                        "@empleado_apellidos",
                        "@empleado_telefono",
                        "@empleado_email",
                        "@empleado_direccion",
                        "@empleado_usuario" },
                        new List<object>() {
                        Entidad.id,
                        Entidad.empleado_nombres,
                        Entidad.empleado_cedula,
                        Entidad.empleado_apellidos,
                        Entidad.empleado_telefono,
                        Entidad.empleado_email,
                        Entidad.empleado_direccion,
                        Entidad.empleado_usuario }
                        );

                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió actualizar el empleado", ex);
            }
        }
    }
}
