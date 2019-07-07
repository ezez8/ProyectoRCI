using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Ronda
    {
        public Carta a;
        public Carta b;
        public Carta c;
        public Carta d;
        public Carta vira;

        public Jugador ja;
        public Jugador jb;
        public Jugador jc;
        public Jugador jd;

        public int[] ganador;

        public PuntajeR puntaje;

        public Turno turno;

        public Ronda(Jugador ja,Jugador jb,Jugador jc, Jugador jd,Turno turno)
        {
            this.puntaje = new PuntajeR();

            this.ja = ja;
            this.jb = jb;
            this.jc = jc;
            this.jd = jd;

            ganador[0] = 0;
            ganador[0] = 0;
            ganador[0] = 0;

            this.turno = turno;
        }

        public void reiniciar()
        {
            a = null;
            b = null;
            c = null;
            d = null;

            puntaje.reiniciar();

            ganador[0] = 0;
            ganador[0] = 0;
            ganador[0] = 0;

            vira = null;
        }

        public void asigVira(Carta vira)
        {
            this.vira = vira;
        }

        public void iniciar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine("<<< PUNTAJE DE LA RONDA >>>");
                Console.WriteLine("Puntaje truco: " + puntaje.truco);
                Console.WriteLine("Puntaje envido: " + puntaje.envido);

                turno.turno = turno.mano;

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine();
                    Console.WriteLine("<---------------CARTAS DE LA MESA--------------->");
                    if (a != null)
                        Console.WriteLine("A >> " + a.toString());
                    else
                        Console.WriteLine("A >> NULL");
                    if (b != null)
                        Console.WriteLine("B >> " + b.toString());
                    else
                        Console.WriteLine("B >> NULL");
                    if (c != null)
                        Console.WriteLine("C >> " + c.toString());
                    else
                        Console.WriteLine("C >> NULL");
                    if (d != null)
                        Console.WriteLine("D >> " + d.toString());
                    else
                        Console.WriteLine("D >> NULL");
                    Console.WriteLine("VIRA >> " + vira.toString());
                    Console.WriteLine("<----------------------------------------------->");

                    Console.WriteLine();
                    Console.WriteLine("< TURNO JUGADOR " + turno.turno.id + " >");

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

                if(a.valor(vira) > c.valor(vira))
                {
                    if(b.valor(vira) > d.valor(vira))
                    {
                        if(a.valor(vira) > b.valor(vira))
                        {
                            ganador[i] = 1;
                        }
                        else if(a.valor(vira) < b.valor(vira))
                        {
                            ganador[i] = 2;
                        }
                        else
                        {
                            ganador[i] = 0;
                        }
                    }
                    else
                    {
                        if (a.valor(vira) > d.valor(vira))
                        {
                            ganador[i] = 1;
                        }
                        else if (a.valor(vira) < d.valor(vira))
                        {
                            ganador[i] = 2;
                        }
                        else
                        {
                            ganador[i] = 0;
                        }
                    }
                }
                else
                {
                    if (b.valor(vira) > d.valor(vira))
                    {
                        if (c.valor(vira) > b.valor(vira))
                        {
                            ganador[i] = 1;
                        }
                        else if (c.valor(vira) < b.valor(vira))
                        {
                            ganador[i] = 2;
                        }
                        else
                        {
                            ganador[i] = 0;
                        }
                    }
                    else
                    {
                        if (c.valor(vira) > d.valor(vira))
                        {
                            ganador[i] = 1;
                        }
                        else if (c.valor(vira) < d.valor(vira))
                        {
                            ganador[i] = 2;
                        }
                        else
                        {
                            ganador[i] = 0;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("---------GANADOR---------");


                a = null;
                b = null;
                c = null;
                d = null;

            }
        }
    }
}
