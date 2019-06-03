using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Partida
    {
        private Jugador a;
        private Jugador b;
        private Jugador c;
        private Jugador d;

        private Mazo mazo;
        private Puntaje puntaje;

        private Ronda ronda;


        public Partida()
        {
            puntaje = new Puntaje();

            mazo = new Mazo();

            a = new Jugador();
            b = new Jugador();
            c = new Jugador();
            d = new Jugador();

            ronda = new Ronda(puntaje,a,b,c,d);
        }

        public void iniciar()
        {
            do
            {
                mazo.reiniciar();
                repartir();
                ronda.iniciar();
            } while (puntaje.gameOver());
        }

        public void repartir()
        {
            a.repartir(mazo.getCarta(),mazo.getCarta(),mazo.getCarta());
        }
    }
}
