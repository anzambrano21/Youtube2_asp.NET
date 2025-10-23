using System.ComponentModel.DataAnnotations.Schema;

namespace web_APIS.Models
{
    [Table("Comentario")]
    public class Comentario
    {
        public int  ID { get; set; }
        public string contenido { get; set; }


        //public int UsuarioID { get; set; }
       // public Usuario? Usuario { get; set; }

        public int VideoID { get; set; }
        public Videos video { get; set; }
        
    }
}
