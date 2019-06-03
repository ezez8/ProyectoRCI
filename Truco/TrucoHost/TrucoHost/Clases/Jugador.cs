using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Jugador
    {
        private Carta a;
        private Carta b;
        private Carta c;

        public Jugador()
        {

        }

        public void repartir(Carta a,Carta b,Carta c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
