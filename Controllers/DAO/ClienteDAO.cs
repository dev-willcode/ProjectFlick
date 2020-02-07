using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class ClienteDAO : IDataAccess<Cliente>
    {
        public override int Create(Cliente Entidad)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CrearCliente"))
            {
                Procedimientos.agregarParametros(cmd,
                    new List<object>() {
                        "@cliente_cedula",
                        "@cliente_apellidos",
                        "@cliente_nombres",
                        "@cliente_telefono",
                        "@cliente_email",
                        "@cliente_direccion",
                        "@cliente_usuario" },
                    new List<object>() {
                        Entidad.cliente_cedula,
                        Entidad.cliente_apellidos,
                        Entidad.cliente_nombres,
                        Entidad.cliente_telefono,
                        Entidad.cliente_email,
                        Entidad.cliente_direccion,
                        Entidad.cliente_usuario, }
                    );

                return Procedimientos.evaluarInsercción(cmd);
            }
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Cliente Get(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Cliente Entidad)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarCliente"))
            {
                Procedimientos.agregarParametros(cmd,
                    new List<object>() {
                        "@id",
                        "@cliente_cedula",
                        "@cliente_apellidos",
                        "@cliente_nombres",
                        "@cliente_telefono",
                        "@cliente_email",
                        "@cliente_direccion"},
                    new List<object>() {
                        Entidad.id,
                        Entidad.cliente_cedula,
                        Entidad.cliente_apellidos,
                        Entidad.cliente_nombres,
                        Entidad.cliente_telefono,
                        Entidad.cliente_email,
                        Entidad.cliente_direccion}
                    );

                return Procedimientos.evaluarActualizacion(cmd);
            }
        }
    }
}
