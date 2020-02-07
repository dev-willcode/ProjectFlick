using System;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class FuncionesDAO : IDataAccess<Funcion>
    {
        public override int Create(Funcion Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Funcion Get(int id)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetFuncion"))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Procedimientos.evaluarObtención<Funcion>(cmd);
            }
        }

        public override bool Update(Funcion Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
