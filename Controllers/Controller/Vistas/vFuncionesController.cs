using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.Utilidades;
using Entity.Entidades.EntidadesPersonalizadas;

namespace Controllers.Controller.Vistas
{
    public class vFuncionesController
    {
        private UtilsProcedimientos Procedimientos = new UtilsProcedimientos();

        public List<VistaFunciones> ListarFunciones()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_VistaFunciones"))
                {
                    return Procedimientos.ListarEntidades<VistaFunciones>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las Funciones activas", ex);
            }
        }

        public List<VistaFunciones> ListarFuncionesActivas()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_FuncionesActivas"))
                {
                    return Procedimientos.ListarEntidades<VistaFunciones>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las Funciones activas", ex);
            }
        }

        public List<VistaFunciones> ListarCategoriasPelicula()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_FuncionesActivas"))
                {
                    return Procedimientos.ListarEntidades<VistaFunciones>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar las Funciones activas", ex);
            }
        }
    }
}
