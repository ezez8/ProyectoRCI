using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class PuntajeP
    {
        public int equipoAC;
        public int equipoBD;

        public PuntajeP()
        {
            equipoAC = 0;
            equipoBD = 0;
        }

        public void reiniciar()
        {
            equipoAC = 0;
            equipoBD = 0;
        }

        public bool gameOver()
        {
            if (equipoAC > 23 || equipoBD > 23)
                return true;
            else
                return false;
        }

        public int ganador()
        {
            if (equipoAC > equipoBD)
                return 1;
            else if (equipoAC < equipoBD)
                return 2;
            else
                return 0;
        }
    }
}
