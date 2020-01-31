using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity.Entidades.Vistas;

namespace Controllers.Controller
{
    public class FuncionesController : FuncionesDAO
    {
        public List<FuncionesActivas> ListarFuncionesActivas()
        {
            using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_FuncionesActivas"))
            {
                List<FuncionesActivas> listado = Procedimientos.ListarEntidades<FuncionesActivas>(cmd);
                foreach (FuncionesActivas item in listado)
                {
                    item.nombre_categoria = asignarListado(item.id_pelicula, "SP_CategoriasPelicula");
                    item.idioma_abreviatura = asignarListado(item.id_pelicula, "SP_IdiomasPelicula");
                    item.pelicula_imagen = devolverImagen(item.id_pelicula);
                }
                return listado;
            }
        }

        private byte[] devolverImagen(int id_pelicula)
        {
            byte[] imagen = null;
            string comando = "SELECT Pelicula.pelicula_imagen " +
                "FROM Pelicula WHERE Pelicula.id = " + id_pelicula;
            using (SqlCommand cmd = Procedimientos.CrearComandoQ(comando))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && reader[0].GetType() != typeof(DBNull))
                    {
                        imagen = (byte[])reader[0];
                    }
                }
            }

            return imagen;
        }

        private List<string> asignarListado(int id_pelicula, string procedimiento)
        {
            List<string> listado = new List<string>();
            using (SqlCommand cmd = Procedimientos.CrearComandoSP(procedimiento))
            {
                cmd.Parameters.AddWithValue("@id", id_pelicula);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listado.Add(reader[0].ToString());
                    }
                }
            }
            return listado;
        }
    }
}
