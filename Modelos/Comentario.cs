using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    //ID_Comentario
    //id_Video
    //comentaario
    internal class Comentario
    {
        public int ID_Comentario { get; set; }

        public Videos id_Video { get; set; }

        public string comentaario { get; set; }
    }
}
