using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    public class Data :EventArgs
    {
        public bool pideTruco { get; set; }
        public bool pideEnvido { get; set; }
        public bool quiero { get; set; }
        public bool noQuiero { get; set; }
        public int cartaRecibida { get; set; }
        public string emisor { get; set; }

        public Data(bool pideTruco, bool pideEnvido, bool quiero, bool noQuiero, int cartaRecibida, string emisor)
        {

        }

       
    }
}
