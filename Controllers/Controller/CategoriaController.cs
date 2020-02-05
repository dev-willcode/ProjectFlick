using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class CategoriaController : CategoriaDAO
    {
        public List<Categoria> ListarCategorias(int id)
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CategoriasPelicula"))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Procedimientos.ListarEntidades<Categoria>(cmd);
            }
        }
    }
}
