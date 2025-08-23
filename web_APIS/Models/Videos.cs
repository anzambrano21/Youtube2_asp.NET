namespace web_APIS.Models
{
    public class Videos
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public string Archivo { get; set; }

        public string descripcion { get; set; }
        public string nombre { get; set; }

        public ICollection<visual>? visuals { get; set; }
        public ICollection<LIkes>? LIkes { get; set; }
        public ICollection<Comentario>? Comentarios { get; set; }
    }
}
