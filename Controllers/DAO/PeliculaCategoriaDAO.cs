using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.DAO
{
    public class PeliculaCategoriaDAO : IDataAccess<Pelicula_Categoria>
    {
        public override int Create(Pelicula_Categoria Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearPeliculaCategoria"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@id_Pelicula",
                        "@id_Categoria"},
                        new List<object>() {
                        Entidad.id_Pelicula,
                        Entidad.id_Categoria}
                        );
                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió crear el Pelicula - Categoria", ex);
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarPeliculaCategoria"))
                {
                    cmd.Parameters.AddWithValue("@idPelicula", id);
                    return Procedimientos.evaluarEliminacion<Pelicula_Categoria>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar la Pelicula - Categoria", ex);
            }
        }

        public override Pelicula_Categoria Get(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Pelicula_Categoria Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
