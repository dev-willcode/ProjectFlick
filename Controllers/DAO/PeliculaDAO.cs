using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class PeliculaDAO : IDataAccess<Pelicula>
    {
        public override int Create(Pelicula Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearPelicula"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@pelicula_titulo",
                        "@pelicula_titulo_original",
                        "@pelicula_duracion",
                        "@pelicula_tipo_censura",
                        "@pelicula_sinopsis",
                        "@pelicula_director",
                        "@pelicula_reparto",
                        "@pelicula_url_trailer",
                        "@pelicula_imagen"},
                        new List<object>() {
                        Entidad.pelicula_titulo,
                        Entidad.pelicula_titulo_original,
                        Entidad.pelicula_duracion,
                        Entidad.pelicula_tipo_censura,
                        Entidad.pelicula_sinopsis,
                        Entidad.pelicula_director,
                        Entidad.pelicula_reparto,
                        Entidad.pelicula_url_trailer,
                        Entidad.pelicula_imagen}
                        );

                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió crear una pelicula", ex);
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarPelicula"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarEliminacion<Cliente>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar la pelicula", ex);
            }
        }

        public override Pelicula Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetPelicula"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Pelicula>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguio obtener la Pelicula", ex);
            }
        }

        public override bool Update(Pelicula Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarPelicula"))
                {
                    Procedimientos.agregarParametros(cmd,
                         new List<object>() {
                        "@id",
                        "@pelicula_titulo",
                        "@pelicula_titulo_original",
                        "@pelicula_duracion",
                        "@pelicula_tipo_censura",
                        "@pelicula_sinopsis",
                        "@pelicula_director",
                        "@pelicula_reparto",
                        "@pelicula_url_trailer",
                        "@pelicula_imagen"},
                        new List<object>() {
                        Entidad.id,
                        Entidad.pelicula_titulo,
                        Entidad.pelicula_titulo_original,
                        Entidad.pelicula_duracion,
                        Entidad.pelicula_tipo_censura,
                        Entidad.pelicula_sinopsis,
                        Entidad.pelicula_director,
                        Entidad.pelicula_reparto,
                        Entidad.pelicula_url_trailer,
                        Entidad.pelicula_imagen}
                        );

                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió actualizar la pelicula", ex);
            }
        }
    }
}
