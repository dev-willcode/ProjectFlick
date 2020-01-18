using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FlickLib.Entidades.Vistas;
using FlickLib.Utilidades;

namespace FlickLib.DAO.Vistas
{
    public class FuncionesActivasDAO : IDataAccess<FuncionesActivas>
    {
        public int Create(FuncionesActivas Entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FuncionesActivas Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, FuncionesActivas Entidad)
        {
            throw new NotImplementedException();
        }

        public List<FuncionesActivas> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_FuncionesActivas";

                List<FuncionesActivas> listado = new List<FuncionesActivas>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listado.Add(new FuncionesActivas(reader));
                    }
                }
               
                return listado;
            }
            
        }
    }
}
