using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class CategoriaDAO : IDataAccess<Categoria>
    {
        public override int Create(Categoria Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Categoria Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetCategoria"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Categoria>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguio obtener un Banco", ex);
            }
        }

        public override bool Update(Categoria Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
