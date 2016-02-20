using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class EntertainData
    {
        abstract public string MusicOrMovie();
        abstract public string EntertainGenre();
        virtual public string EntertainName() {
            return "Prabh-Shop";
        }
    }
}
