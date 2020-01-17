using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FlickLib.Entidades;
using FlickLib.Utilidades;

namespace FlickLib.DAO
{
    class ClienteDAO : IDataAccess<Cliente>
    {
        UtilsProcedimientos proced = new UtilsProcedimientos();
        public int Create(Cliente Entidad)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CrearCliente";
                proced.agregarParametros(cmd,
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

                return proced.evaluarInsercción(cmd);
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

        public bool Update(int id, Cliente Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
