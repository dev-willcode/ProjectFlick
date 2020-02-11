using System;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class PeliculaDAO : IDataAccess<Pelicula>
    {
        public override int Create(Pelicula Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
