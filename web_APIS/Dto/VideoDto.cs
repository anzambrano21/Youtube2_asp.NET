namespace web_APIS.Dto
{
    public class VideoDto
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Archivo { get; set; }
        public string descripcion { get; set; }
    }
}
