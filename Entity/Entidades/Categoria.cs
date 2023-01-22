using System;
using System.Data;

namespace Entity.Entidades
{
    public class Categoria : Entidad
    {
        public Categoria()
        {
        }

        public Categoria(IDataReader data)
        {
            id = (int)data["id"];
            nombre_categoria = data["nombre_categoria"].ToString();
        }

        public int id { get;  set; }

        public string nombre_categoria { get;  set; }
    }
}
