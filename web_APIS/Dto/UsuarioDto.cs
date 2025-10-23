namespace web_APIS.Dto
{
    public class UsuarioDto
    {
        public int ID { get; set; }

        public string nombre { get; set; }
        public string email { get; set; }
        
        public bool estado { get; set; }

        public List<VideoDto> Videos { get; set; }
    }
}
