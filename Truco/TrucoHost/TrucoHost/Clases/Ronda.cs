using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Ronda
    {
        private Carta a;
        private Carta b;
        private Carta c;
        private Carta d;
        private Carta vira;

        private Jugador ja;
        private Jugador jb;
        private Jugador jc;
        private Jugador jd;

        private int gandorR0;
        private int gandorR1;
        private int gandorR2;

        private Puntaje puntaje;

        public Ronda(Puntaje punta,Jugador ja,Jugador jb,Jugador jc, Jugador jd)
        {
            this.puntaje = puntaje;

            this.ja = ja;
            this.jb = jb;
            this.jc = jc;
            this.jd = jd;

            gandorR0 = 0;
            gandorR1 = 0;
            gandorR2 = 0;
        }

        public void reiniciar()
        {
            a = null;
            b = null;
            c = null;
            d = null;
            puntaje.reiniciar();
        }

        public void iniciar()
        {
            for (int rondaN = 0; rondaN < 3; rondaN++)
            {
                

                if (gandorR0 == 0 && gandorR1 != 0)
                    break;
            }
        }
    }
}
