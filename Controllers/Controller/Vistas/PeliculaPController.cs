using Controllers.Utilidades;
using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Controller.Vistas
{
    public class PeliculaPController
    {
        private UtilsProcedimientos Procedimientos = new UtilsProcedimientos();

        public List<PeliculaP> ListarPeliculas()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarPeliculasP"))
                {
                    return Procedimientos.ListarEntidades<PeliculaP>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las Peliculas", ex);
            }

        }
    }
}
