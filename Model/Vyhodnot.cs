using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNP_Urban.Model
{
    class Vyhodnot
    {
        public Vyhodnot()
        {

        }

        public int Vyhodnoceni(int PObrazek, int UObrazek)
        {
            if (PObrazek == 1 && UObrazek == 4 || PObrazek == 2 && UObrazek == 5 || PObrazek == 3 && UObrazek == 6)
            { return 1; }
            if (PObrazek == 1 && UObrazek == 5 || PObrazek == 2 && UObrazek == 6 || PObrazek == 3 && UObrazek == 4)
            { return 2; }
            if (PObrazek == 1 && UObrazek == 6 || PObrazek == 2 && UObrazek == 4 || PObrazek == 3 && UObrazek == 5)
            { return 3; }
            return 0;
        }
    }
}
