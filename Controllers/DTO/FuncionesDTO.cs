using System;
using System.Collections.Generic;
using DataAccess.DAO.Vistas;
using Entity.Entidades.Vistas;

namespace Controllers.DTO
{
    public class FuncionesDTO
    {
        private FuncionesActivasDAO FuncionesActivasDAO { get; set; }

        public FuncionesDTO()
        {
            FuncionesActivasDAO = new FuncionesActivasDAO();
        }

        public List<FuncionesActivas> ListarFuncionesActivas()
        {
            return FuncionesActivasDAO.GetAll();
        }
    }
}
