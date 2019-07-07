using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Partida
    {
        Jugador a;
        Jugador b;
        Jugador c;
        Jugador d;

        Mazo mazo;
        PuntajeP puntaje;

        Ronda ronda;

        Turno turno;


        public Partida()
        {
            puntaje = new PuntajeP();

            mazo = new Mazo();

            a = new Jugador('a');
            b = new Jugador('b');
            c = new Jugador('c');
            d = new Jugador('d');

            turno = new Turno(d);

            ronda = new Ronda(a,b,c,d,turno);
        }

        public void iniciar()
        {
            do
            {
                mazo.reiniciar();

                a.reiniciar();
                b.reiniciar();
                c.reiniciar();
                d.reiniciar();

                ronda.reiniciar();

                repartir();

                switch (turno.mano.id)
                {
                    case 'a':
                        turno.mano = b;
                        turno.turno = b;
                        break;
                    case 'b':
                        turno.mano = c;
                        turno.turno = c;
                        break;
                    case 'c':
                        turno.mano = d;
                        turno.turno = d;
                        break;
                    case 'd':
                        turno.mano = a;
                        turno.turno = a;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("<<<<<< PUNTAJE DE LA PARTIDA >>>>>>");
                Console.WriteLine("Puntaje equipo AC: " + puntaje.equipoAC);
                Console.WriteLine("Puntaje equipo BD: " + puntaje.equipoBD);

                Console.WriteLine();
                Console.WriteLine("<<<<<< NUEVA RONDA >>>>>>");

                ronda.iniciar();

            } while (puntaje.gameOver());
        }

        public void repartir()
        {
            a.repartir(mazo.getCarta(),mazo.getCarta(),mazo.getCarta());
            b.repartir(mazo.getCarta(), mazo.getCarta(), mazo.getCarta());
            c.repartir(mazo.getCarta(), mazo.getCarta(), mazo.getCarta());
            d.repartir(mazo.getCarta(), mazo.getCarta(), mazo.getCarta());

            ronda.asigVira(mazo.getCarta());
        }
    }
}
