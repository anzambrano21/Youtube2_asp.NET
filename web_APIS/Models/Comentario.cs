namespace web_APIS.Models
{
    public class Comentario
    {
        public int  ID { get; set; }

        public Videos video { get; set; }
        public string contenido { get; set; }
    }
}
