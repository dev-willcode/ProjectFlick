using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class CategoriaController : CategoriaDAO
    {
        public string ListarCategoriasString(int id)
        {
            try
            {
                string resul = "";
                List<Categoria> lista = ListarCategorias(id);
                if (lista.Count != 0)
                {
                    lista.ForEach(categoria => resul += categoria.categoria_nombre + " , ");
                    resul = resul.Substring(0, resul.Length - 2);
                }
                return resul;
            }
            catch (Exception ex)
            {

                throw ex;
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
