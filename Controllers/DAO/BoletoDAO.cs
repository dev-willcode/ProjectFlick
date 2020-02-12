using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO.Vistas
{
    public class BoletoDAO : IDataAccess<Boleto>
    {
        public override int Create(Boleto Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearBoleto"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@boleto_factura",
                        "@boleto_funcion",
                        "@boleto_asiento",
                        "@boleto_tipo_asiento",
                        "@boleto_medio_compra"},
                        new List<object>() {
                        Entidad.boleto_factura,
                        Entidad.boleto_funcion,
                        Entidad.boleto_asiento,
                        Entidad.boleto_tipo_asiento,
                        Entidad.boleto_medio_compra}
                        );

                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió crear el boleto", ex);
            }
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Boleto Get(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Boleto Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
