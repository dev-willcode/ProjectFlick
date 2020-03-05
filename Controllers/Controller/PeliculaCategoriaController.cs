using Controllers.DAO;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.Controller
{
    public class PeliculaCategoriaController : PeliculaCategoriaDAO
    {
        public List<Pelicula_Categoria> ListarPeliculaCategoria(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarPeliculaCategoria"))
                {
                    cmd.Parameters.AddWithValue("@idPelicula", id);
                    return Procedimientos.ListarEntidades<Pelicula_Categoria>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las Pelicula - Categoria", ex);
            }
        }
    }
}
