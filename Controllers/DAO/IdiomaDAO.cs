using System;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class IdiomaDAO : IDataAccess<Idioma>
    {
        public override int Create(Idioma Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Idioma Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_IdiomasPelicula"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Idioma>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener el Idioma de la Pelicula",ex);
            }
        }

        public override bool Update(Idioma Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
