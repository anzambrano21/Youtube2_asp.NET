namespace web_APIS.Models
{
    public class LIkes
    {
        public int ID { get; set; }

        public int VideoID { get; set; }
        public Videos? Video { get; set; }

        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
    }
}
