using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Turno
    {
        public Jugador mano;
        public Jugador turno;

        public Turno(Jugador d)
        {
            mano = d;
            turno = d;
        }
    }
}
