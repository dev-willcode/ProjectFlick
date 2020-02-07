using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class BancoDAO : IDataAccess<Banco>
    {
        public override int Create(Banco Entidad)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearBanco"))
            {
                Procedimientos.agregarParametros(cmd,
                    new List<object>() {
                        "@banco_nombre",
                        "@banco_estado"},
                    new List<object>() {
                        Entidad.banco_nombre,
                        Entidad.banco_estado}
                    );

                return Procedimientos.evaluarInsercción(cmd);
            }
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
