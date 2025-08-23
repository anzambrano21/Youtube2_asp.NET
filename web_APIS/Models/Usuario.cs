namespace web_APIS.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        public ICollection<Videos>? Videos { get; set; }

        public string? nombre { get; set; }
        public string? email { get; set; }
        public string? pasword { get; set; }
        public bool estado { get; set; }
    }
}
