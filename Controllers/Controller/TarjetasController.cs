using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Controllers.DAO;
using Controllers.Utilidades;
using Entity.Entidades;

namespace Controllers.Controller
{

    public class TarjetasController
    {
        public TarjetasDAO TarjetasDAO { get; set; }

        public TarjetasController()
        {
            TarjetasDAO = new TarjetasDAO();
        }

        public List<Tarjetas> ObtenerTarjetasCliente(int idCliente)
        {
            List<Tarjetas> listaTarjeta = GetAll(idCliente);
            if (listaTarjeta.Count == 0)
            {
                return null;
            }
            else
            {
                return listaTarjeta;
            }
        }
        private List<Tarjetas> GetAll(int id)
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
