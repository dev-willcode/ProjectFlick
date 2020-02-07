﻿using System.Data;

namespace Entity.Entidades
{
    public class Tarjetas : Entidad
    {
        public Tarjetas()
        {
        }

        public Tarjetas(IDataReader data)
        {
            id = (int)data["id"];
            tarjeta_cliente = (int)data["tarjeta_cliente"];
            tarjeta_banco = (int)data["tarjeta_banco"];
            tarjeta_numero = data["tarjeta_numero"].ToString();
            tarjeta_ccv = data["tarjeta_ccv"].ToString();
            tarjeta_anio = data["tarjeta_ano"].ToString();
            tarjeta_mes = data["tarjeta_mes"].ToString();
            tarjeta_propietario = data["tarjeta_propietario"].ToString();
        }

        public int id { get; set; }
        public int tarjeta_cliente { get; set; }
        public int tarjeta_banco { get; set; }
        public string tarjeta_numero { get; set; }
        public string tarjeta_ccv { get; set; }
        public string tarjeta_anio { get; set; }
        public string tarjeta_mes { get; set; }
        public string tarjeta_propietario { get; set; }
    }
}
