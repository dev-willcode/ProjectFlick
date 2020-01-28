namespace Entity.Entidades
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
