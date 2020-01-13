namespace FlickLibrary.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public int id { get; private set; }

        public string usuario_username { get; private set; }

        public string usuario_password { get; private set; }

        public int usuario_perfil { get; private set; }
    }
}
