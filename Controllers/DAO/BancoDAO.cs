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
            try
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
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguio crear un Banco", ex);
            }
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Banco Get(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_GetBanco"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarObtención<Banco>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguio obtener un Banco", ex);
            }
        }

        public override bool Update(Banco Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
