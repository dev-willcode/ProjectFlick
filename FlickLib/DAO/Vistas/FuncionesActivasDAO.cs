using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FlickLib.Entidades.Vistas;
using FlickLib.Utilidades;

namespace FlickLib.DAO.Vistas
{
    public class FuncionesActivasDAO : IDataAccess<FuncionesActivas>
    {
        public int Create(FuncionesActivas Entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FuncionesActivas Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, FuncionesActivas Entidad)
        {
            throw new NotImplementedException();
        }

        public List<FuncionesActivas> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_FuncionesActivas";

                FuncionesActivas funcion;
                List<FuncionesActivas> listado = new List<FuncionesActivas>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        funcion = new FuncionesActivas(reader);
                        listado.Add(funcion);
                    }
                }
                foreach (FuncionesActivas item in listado)
                {
                    item.nombre_categoria = asignar(item.id_pelicula, "SP_CategoriasPelicula");
                    item.idioma_abreviatura = asignar(item.id_pelicula, "SP_IdiomasPelicula");
                    item.pelicula_imagen = devolverImagen(item.id_pelicula);
                }
                return listado;
            }

        }

        private byte[] devolverImagen(int id_pelicula)
        {
            byte[] imagen = null;
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Pelicula.pelicula_imagen FROM Pelicula " +
                "WHERE Pelicula.id = " + id_pelicula;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && reader[0].GetType() != typeof(DBNull))
                        imagen = (byte[])reader[0];
                }
            }

            return imagen;
        }

        private List<string> asignar(int id_pelicula, string procedimiento)
        {
            List<string> listado = new List<string>();
            using (SqlCommand cmd = new SqlCommand(null, Configuraciones.connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento;
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
