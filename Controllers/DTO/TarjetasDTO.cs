using DataAccess.DAO;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DTO
{

    public class TarjetasDTO
    {
        public TarjetasDAO TarjetasDAO { get; set; }

        public TarjetasDTO()
        {
            TarjetasDAO = new TarjetasDAO();
        }

        public List<Tarjetas> ObtenerTarjetasCliente(int idCliente)
        {
            List<Tarjetas> listaTarjeta = TarjetasDAO.GetAll(idCliente);
            if (listaTarjeta.Count == 0)
            {
                return null;
            }
            else
            {
                return listaTarjeta;
            }
        }
    }
}
