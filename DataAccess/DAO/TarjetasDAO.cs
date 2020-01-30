using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Utilidades;
using Entity.Entidades;

namespace DataAccess.DAO
{
    public class TarjetasDAO : IDataAccess<Tarjetas>
    {
        UtilsProcedimientos proced = new UtilsProcedimientos();
        public int Create(Tarjetas Entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Tarjetas Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Tarjetas Entidad)
        {
            throw new NotImplementedException();
        }

        public List<Tarjetas> GetAll(int id)
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BuscarTarjetas";
                cmd.Parameters.AddWithValue("@idCliente", id);
                
                Tarjetas tarjetas;
                List<Tarjetas> listado = new List<Tarjetas>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tarjetas = new Tarjetas(reader);
                        listado.Add(tarjetas);
                    }
                }
                return listado;
            }
        }
    }
}
