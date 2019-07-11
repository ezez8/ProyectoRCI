using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Partida
    {
        Puerto puerto;

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
            puerto = new Puerto();

            puntaje = new PuntajeP();

            mazo = new Mazo();

            a = new Jugador("A");
            b = new Jugador("B");
            c = new Jugador("C");
            d = new Jugador("D");

            turno = new Turno(d);

            ronda = new Ronda(a,b,c,d,turno,puerto);
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
                puerto.recogerCartas();

                repartir();

                switch (turno.mano.id)
                {
                    case "A":
                        turno.mano = b;
                        turno.turno = b;
                        break;
                    case "B":
                        turno.mano = c;
                        turno.turno = c;
                        break;
                    case "C":
                        turno.mano = d;
                        turno.turno = d;
                        break;
                    case "D":
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

                ronda.iniciar(puntaje);
                puerto.actualizarPuntaje(puntaje.equipoAC,puntaje.equipoBD);
                
            } while (puntaje.gameOver());
        }

        public void repartir()
        {
            a.repartir(mazo.getCarta(),mazo.getCarta(),mazo.getCarta());
            puerto.repartir(a.id, a.a.id + a.b.id + a.c.id);

            b.repartir(mazo.getCarta(), mazo.getCarta(), mazo.getCarta());
            puerto.repartir(b.id, b.a.id + b.b.id + b.c.id);

            c.repartir(mazo.getCarta(), mazo.getCarta(), mazo.getCarta());
            puerto.repartir(c.id, c.a.id + c.b.id + c.c.id);

            d.repartir(mazo.getCarta(), mazo.getCarta(), mazo.getCarta());
            puerto.repartir(d.id, d.a.id + d.b.id + d.c.id);
                        
            ronda.asigVira(mazo.getCarta());
            puerto.repartirVira(ronda.vira.id);
        }
    }
}
