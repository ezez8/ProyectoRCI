using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Carta
    {
        public string id;
        public string num;
        public string palo;

        public Carta(string palo, string num, string id)
        {
            this.id = id;
            this.num = num;
            this.palo = palo;
        }

        public int valor(Carta vira)
        {
            if (palo == vira.palo) {
                if (vira.num == "10" && num == "12")
                    return 14;
                if (vira.num == "11" && num == "12")
                    return 15;
                if (vira.num != "10" && num == "10")
                    return 14;
                if (vira.num != "11" && num == "11")
                    return 15;
            }


            if (num == "#4")
                return 0;
            else if (num == "#5")
                return 1;
            else if (num == "#6")
                return 2;
            else if (num == "#7" && (palo == "C" || palo == "B"))
                return 3;
            else if (num == "10")
                return 4;
            else if (num == "11")
                return 5;
            else if (num == "12")
                return 6;
            else if (num == "#1" && (palo == "C" || palo == "O"))
                return 7;
            else if (num == "#2")
                return 8;
            else if (num == "#3")
                return 9;
            else if (num == "#7" && palo == "O")
                return 10;
            else if (num == "#7" && palo == "E")
                return 11;
            else if (num == "#1" && palo == "B")
                return 12;
            else if (num == "#1" && palo == "E")
                return 13;
            else
                return -1;              
        }

        public string toString()
        {
            return palo + " | " + num;
        }
    }
}
