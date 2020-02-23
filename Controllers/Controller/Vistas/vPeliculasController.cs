using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller.Vistas
{
    public class vPeliculasController: PeliculaDAO
    {
        public List<Pelicula> ListarPeliculas()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarPeliculas"))
                {
                    return Procedimientos.ListarEntidades<Pelicula>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las peliculas", ex);
            }
        }
    }
}
