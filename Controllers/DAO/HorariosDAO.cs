using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class HorariosDAO : IDataAccess<Horarios>
    {
        public override int Create(Horarios Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearHorario"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@hora_inicio",
                        "@hora_fin",},
                        new List<object>() {
                        Entidad.horario_inicio,
                        Entidad.horario_fin}
                        );
                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió crear el Horario", ex);
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarHorario"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarEliminacion<Tarjetas>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar el Horario", ex);
            }
        }

        public override Horarios Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetHorario"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Horarios>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener el Horario", ex);
            }
        }

        public override bool Update(Horarios Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarHorario"))
                {
                    Procedimientos.agregarParametros(cmd,
                     new List<object>() {
                        "@hora_inicio",
                        "@hora_fin",},
                        new List<object>() {
                        Entidad.horario_inicio,
                        Entidad.horario_fin}
                        );
                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió actualizar el horario", ex);
            }
        }
    }
}
