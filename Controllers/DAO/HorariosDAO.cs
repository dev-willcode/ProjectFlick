using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class HorariosDAO : IDataAccess<Horarios>
    {
        public override int Create(Horarios Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Horarios Get(int id)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetHorario"))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Procedimientos.evaluarObtención<Horarios>(cmd);
            }
        }

        public override bool Update(Horarios Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
