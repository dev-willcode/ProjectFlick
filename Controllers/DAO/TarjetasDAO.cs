using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class TarjetasDAO : IDataAccess<Tarjetas>
    {
        public override int Create(Tarjetas Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearTarjeta"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@tarjeta_cliente",
                        "@tarjeta_tipo",
                        "@tarjeta_banco",
                        "@tarjeta_numero",
                        "@tarjeta_ccv",
                        "@tarjeta_ano",
                        "@tarjeta_mes",
                        "@tarjeta_propietario"},
                        new List<object>() {
                        Entidad.tarjeta_cliente,
                        Entidad.tarjeta_tipo,
                        Entidad.tarjeta_banco,
                        Entidad.tarjeta_numero,
                        Entidad.tarjeta_ccv,
                        Entidad.tarjeta_anio,
                        Entidad.tarjeta_mes,
                        Entidad.tarjeta_propietario}
                        );
                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió crear la Tarjeta", ex);
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BorrarTarjeta"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.evaluarEliminacion<Tarjetas>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió eliminar la Tarjeta", ex);
            }
        }

        public override Tarjetas Get(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Tarjetas Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
