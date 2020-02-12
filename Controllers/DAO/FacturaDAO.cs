using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class FacturaDAO : IDataAccess<Factura>
    {
        public override int Create(Factura Entidad)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearFactura"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() {
                        "@factura_cliente",
                        "@factura_funcion",
                        "@factura_metodo_pago",
                        "@factura_fecha_emision"},
                        new List<object>() {
                        Entidad.factura_cliente,
                        Entidad.factura_funcion,
                        Entidad.factura_metodo_pago,
                        Entidad.factura_fecha_emision});

                    return Procedimientos.evaluarInsercción(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió crear un cliente", ex);
            }
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Factura Get(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Factura Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
