using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Controllers.Controller;
using Controllers.Utilidades;
using Entity.Entidades;

namespace Controllers.DAO
{
    public class ClienteDAO : IController, IDataAccess<Cliente>
    {
        public int Create(Cliente Entidad)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CrearCliente";
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

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente Entidad)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarCliente";
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
