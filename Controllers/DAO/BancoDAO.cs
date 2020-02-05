using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAO
{
    public class BancoDAO : IDataAccess<Banco>
    {
        public override int Create(Banco Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Banco Get(int id)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetBanco"))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Procedimientos.evaluarObtención<Banco>(cmd);
            }
        }

        public override bool Update(Banco Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
