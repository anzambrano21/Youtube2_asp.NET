using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    //ID_like int
    //ID_user int
    //ID_video int
    internal class Likes
    {
        public int ID_like { get; set; }
        public Usuario ID_user { get; set; }
        public Videos ID_video { get; set; }
    }
}
