using System;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class Sala_CineDAO : IDataAccess<Sala_Cine>
    {
        public override int Create(Sala_Cine Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Sala_Cine Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetSalaCine"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Sala_Cine>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió obtener la Sala Cine", ex);
            }
        }

        public override bool Update(Sala_Cine Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
