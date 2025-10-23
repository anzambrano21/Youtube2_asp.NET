namespace web_APIS.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        public List<Videos>? Videos { get; set; } = new();

        public string? nombre { get; set; }
        public string? email { get; set; }
        public string? pasword { get; set; }
        public bool estado { get; set; }
    }
}
