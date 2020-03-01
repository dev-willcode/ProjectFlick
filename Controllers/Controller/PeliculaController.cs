using Controllers.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.Controller
{
    public class PeliculaController : PeliculaDAO
    {
        public bool UpdateImagen(int id, byte[] imagen)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ActualizarImagenPelicula"))
                {
                    Procedimientos.agregarParametros(cmd,
                        new List<object>() { "@id", "@imagen", },
                        new List<object>() { id, imagen, });
                    return Procedimientos.evaluarActualizacion(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguío actualizar la imagen", ex);
            }
        }
    }
}
