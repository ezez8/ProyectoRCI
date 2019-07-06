using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Ronda
    {
        Carta a;
        Carta b;
        Carta c;
        Carta d;
        public Carta vira;

        Jugador ja;
        Jugador jb;
        Jugador jc;
        Jugador jd;

        int gandorR0;
        int gandorR1;
        int gandorR2;

        PuntajeR puntaje;

        Turno turno;

        public Ronda(Jugador ja,Jugador jb,Jugador jc, Jugador jd,Turno turno)
        {
            this.puntaje = new PuntajeR();

            this.ja = ja;
            this.jb = jb;
            this.jc = jc;
            this.jd = jd;

            gandorR0 = 0;
            gandorR1 = 0;
            gandorR2 = 0;

            this.turno = turno;
        }

        public void reiniciar()
        {
            a = null;
            b = null;
            c = null;
            d = null;

            puntaje.reiniciar();

            gandorR0 = 0;
            gandorR1 = 0;
            gandorR2 = 0;

            vira = null;
        }

        public void asigVira(Carta vira)
        {
            this.vira = vira;
        }

        public void iniciar()
        {
            for (int rondaN = 1; rondaN < 4; rondaN++)
            {
                Console.WriteLine("<<< Ronda " + rondaN + " >>>");
                Console.WriteLine("Puntaje truco: " + puntaje.truco);
                Console.WriteLine("Puntaje envido: " + puntaje.envido);
                Console.WriteLine("----------------------------------------------------");

                turno.turno = turno.mano;

                for (int turnoN = 1; turnoN < 5; turnoN++)
                {
                    Console.WriteLine("< Turno jugador " + turno.turno.id + " >");

                    switch (turno.turno.id)
                    {
                        case 'a':
                            a = turno.turno.jugarCarta();
                            turno.turno = jb;
                            break;
                        case 'b':
                            b = turno.turno.jugarCarta();
                            turno.turno = jc;
                            break;
                        case 'c':
                            c = turno.turno.jugarCarta();
                            turno.turno = jd;
                            break;
                        case 'd':
                            d = turno.turno.jugarCarta();
                            turno.turno = ja;
                            break;
                    }
                }

            }
        }
    }
}
