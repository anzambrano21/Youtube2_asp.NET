using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    //ID_Video int 
    //id_user int 
    //Archivo String
    //descripcion String
    internal class Videos
    {
        public int ID_Video { get; set; }

        public Usuario id_user { get; set; }

        public string Archivo { get; set; }

        public string descripcion { get; set; }
    }
}
