using web_APIS.Models;

namespace web_APIS.Dto
{
    public class ComentarioDto
    {
        public int ID { get; set; }
        public string contenido { get; set; }


        //public int UsuarioID { get; set; }
        // public Usuario? Usuario { get; set; }

        public int VideoID { get; set; }
        public Videos video { get; set; }
    }
}
