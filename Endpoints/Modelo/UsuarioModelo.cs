namespace Endpoints.Modelo
{
    public class UsuarioModelo
    {
        public UsuarioModelo() { }

        public UsuarioModelo(int id, string nombre, string email, string contrasena, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;
            Activo = activo;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Contrasena { get; set; }
        public bool Activo { get; set; }
    }
}
