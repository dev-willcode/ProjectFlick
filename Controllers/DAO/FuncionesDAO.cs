using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class FuncionesDAO : IDataAccess<Funcion>
    {
        public override int Create(Funcion Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearFuncion"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@funcion_pelicula",
                        "@funcion_sala",
                        "@funcion_fecha_evento",
                        "@funcion_horario",
                        "@funcion_estado",
                        "@funcion_precio_boleto",
                        "@funcion_fecha_creacion",
                        "@funcion_idioma",
                        "@funcion_asientos_disponibles"},
                        new List<object>() {
                        Entidad.funcion_pelicula,
                        Entidad.funcion_sala,
                        Entidad.funcion_fecha_evento,
                        Entidad.funcion_horario,
                        Entidad.funcion_estado,
                        Entidad.funcion_precio_boleto,
                        Entidad.funcion_fecha_creacion,
                        Entidad.funcion_idioma,
                        Entidad.funcion_asientos_disponibles}
                        );

                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguio crear una Funcion", ex);
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarFuncion"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarEliminacion<Funcion>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar la funcion", ex);
            }
        }

        public override Funcion Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetFuncion"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Funcion>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener la Función", ex);
            }
        }

        public override bool Update(Funcion Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarFuncion"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@id",
                        "@funcion_pelicula",
                        "@funcion_sala",
                        "@funcion_fecha_evento",
                        "@funcion_horario",
                        "@funcion_estado",
                        "@funcion_precio_boleto",
                        "@funcion_fecha_creacion",
                        "@funcion_idioma",
                        "@funcion_asientos_disponibles"},
                        new List<object>() {
                        Entidad.id,
                        Entidad.funcion_pelicula,
                        Entidad.funcion_sala,
                        Entidad.funcion_fecha_evento,
                        Entidad.funcion_horario,
                        Entidad.funcion_estado,
                        Entidad.funcion_precio_boleto,
                        Entidad.funcion_fecha_creacion,
                        Entidad.funcion_idioma,
                        Entidad.funcion_asientos_disponibles}
                        );

                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió actualizar la funcion", ex);
            }
        }
    }
}
