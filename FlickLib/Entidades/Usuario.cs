using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickLib.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
        }
        public int id { get; set; }

        public string usuario_username { get; set; }

        public string usuario_password { get; set; }

        public int usuario_perfil { get; set; }
    }
}
