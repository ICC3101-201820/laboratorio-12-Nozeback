using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class OnEliminarComidasArgs:EventArgs
    {
        public string name;
        public double prote;
        public double carbos;
        public double grasa;
    }
}
