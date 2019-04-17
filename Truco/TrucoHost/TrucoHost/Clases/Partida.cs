using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Partida
    {
        List<Jugador> jugadores;
        
        public Partida()
        {
            jugadores = new List<Jugador>();
            for(int i = 0; i < 4; i++)
                jugadores.Add(new Jugador());
        }
    }
}
