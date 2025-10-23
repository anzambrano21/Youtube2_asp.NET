namespace web_APIS.Models
{
    public class Videos
    {
        public int ID { get; set; }

        public string Archivo { get; set; }

        public string descripcion { get; set; }
        public string nombre { get; set; }

        public int UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }

        public List<visual>? visuals { get; set; } = new();
        public List<LIkes>? LIkes { get; set; } = new();
        public ICollection<Comentario> Comentarios { get; set; }

    }
}
