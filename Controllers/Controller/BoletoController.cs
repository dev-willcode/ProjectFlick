﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Controllers.DAO.Vistas;
using Entity.Entidades;

namespace Controllers.Controller
{
    public class BoletoController : BoletoDAO
    {
        public List<Boleto> listarBoletos(int idCliente)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BoletosCliente"))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    return Procedimientos.ListarEntidades<Boleto>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió listar los Boletos", ex);
            }

        }

        public List<Boleto> ListarBoletosFuncion(int id)
        {
            try
            {
                using (SqlCommand cmd = Procedimientos.CrearComandoSP("SP_BoletosFuncion"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Procedimientos.ListarEntidades<Boleto>(cmd);
                }
            }
            catch (Exception ex)
            {

                throw new ControllerException("No se consiguió listar Boletos por Función", ex);
            }

        }
    }
}
