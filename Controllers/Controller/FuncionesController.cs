using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class FuncionesController : FuncionesDAO
    {
        public List<Funcion> ListarFuncionesActivas()
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_FuncionesActivas"))
            {
                return Procedimientos.ListarEntidades<Funcion>(cmd);
            }
        }
    }
}
