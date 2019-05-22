using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Partida
    {
        private List<Jugador> jugadores;
        private Mazo mazo;
        private Puntaje puntaje;


        public Partida()
        {
            puntaje = new Puntaje();

            mazo = new Mazo();

            jugadores = new List<Jugador>();
            for(int i = 0; i < 4; i++)
                jugadores.Add(new Jugador());
        }

        public void iniciar()
        {
            do
            {
                
            } while (puntaje.gameOver());
        }
    }
}
