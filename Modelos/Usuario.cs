using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    //ID_user
    //nombre
    //email
    //pasword
    //estado
    internal class Usuario
    {
        public int ID_user { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string pasword { get; set; }
        public bool  estado { get; set; }
        

    }
}
