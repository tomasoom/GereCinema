using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCinema
{
    public partial class Lugar
    {
        public Lugar()
        {

        }

        public Lugar(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Ocupado = false;
        }
    }
}
