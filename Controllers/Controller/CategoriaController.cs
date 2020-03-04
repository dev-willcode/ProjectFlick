using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class CategoriaController : CategoriaDAO
    {
        public List<Categoria> ListarCategorias()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarCategorias"))
                {
                    return Procedimientos.ListarEntidades<Categoria>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió listar Categorias", ex);
            }
        }

        public string ListarCategoriasString(int id)
        {

            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ObtenerCategorias"))
                {
                    cmd.Parameters.AddWithValue("@idPelicula", id);
                    return Procedimientos.obtenerString(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió listar Categorias", ex);
            }
        }

        public List<Categoria> ListarCategorias(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_CategoriasPelicula"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.ListarEntidades<Categoria>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió listar Categorias", ex);
            }
        }
    }
}
