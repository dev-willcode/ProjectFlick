﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class HorarioController : HorariosDAO
    {
        public List<Horarios> ListarHorarios()
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_ListarHorarios"))
                {
                    return Procedimientos.ListarEntidades<Horarios>(cmd);
                }
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar los horarios", ex);
            }
        }
    }
}