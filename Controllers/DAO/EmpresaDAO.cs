using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class EmpresaDAO : IDataAccess<Empresa>
    {
        public override int Create(Empresa Entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Empresa Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetEmpresa"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Empresa>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguio obtener una Empresa", ex);
            }
        }

        public override bool Update(Empresa Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
