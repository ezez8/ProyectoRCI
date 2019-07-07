using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Carta
    {
        string num;
        string palo;

        public Carta(string palo, string num)
        {
            this.num = num;
            this.palo = palo;
        }

        public string toString()
        {
            return palo + " | " + num;
        }
    }
}
