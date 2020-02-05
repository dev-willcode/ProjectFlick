using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetSalaCine"))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Procedimientos.evaluarObtención<Sala_Cine>(cmd);
            }
        }

        public override bool Update(Sala_Cine Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
