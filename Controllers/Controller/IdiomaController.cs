﻿using Controllers.DAO;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controllers.Controller
{
    public class IdiomaController : IdiomaDAO
    {
        public List<Idioma> ListarIdiomas()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarIdiomas"))
                {
                    return Procedimientos.ListarEntidades<Idioma>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar los idiomas", ex);
            }
        }
    }
}
