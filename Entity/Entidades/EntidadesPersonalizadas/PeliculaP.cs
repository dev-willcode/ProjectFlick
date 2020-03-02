using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades.EntidadesPersonalizadas
{
    public class PeliculaP : Entidad
    {
        public PeliculaP(IDataReader data)
        {
            ID = (int)data["funcion_pelicula"];
            Titulo = data["pelicula_titulo"].ToString();
            Titulo_Original = data["pelicula_titulo_original"].ToString();
            Duracion = data["pelicula_duracion"].ToString();
            Censura = data["pelicula_tipo_censura"].ToString();
            Director = data["pelicula_director"].ToString();          
        }

        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Titulo_Original { get; set; }

        public string Duracion { get; set; }

        public string Censura { get; set; }

        public string Director { get; set; }
    }
}
