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
            Titulo = data["Titulo"].ToString();
            Titulo_Original = data["Titulo Original"].ToString();
            Duracion = data["Duracion"].ToString();
            Censura = data["Censura"].ToString();
            Director = data["Director"].ToString();          
        }

        public string Titulo { get; set; }

        public string Titulo_Original { get; set; }

        public string Duracion { get; set; }

        public string Censura { get; set; }

        public string Director { get; set; }
    }
}
