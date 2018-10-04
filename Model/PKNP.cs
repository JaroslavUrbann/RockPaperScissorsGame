using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNP_Urban.Model
{
    class PKNP
    {
        public int[] KNP = {1,2,3};
        public PKNP()
        {

        }

        public int VyberKNP()
        {
            Random rnd = new Random();
            return KNP[rnd.Next(0, 3)];
        }
    }
}
