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

        public int rendirse;

        public Puerto puerto;

        public Ronda(Jugador ja,Jugador jb,Jugador jc, Jugador jd,Turno turno,Puerto puerto)
        {
            this.puerto = puerto;

            this.puntaje = new PuntajeR();

            this.ja = ja;
            this.jb = jb;
            this.jc = jc;
            this.jd = jd;

            ganador = new int[3];

            ganador[0] = 0;
            ganador[1] = 0;
            ganador[2] = 0;

            this.turno = turno;

            rendirse = 0;
        }

        public void reiniciar()
        {
            a = null;
            b = null;
            c = null;
            d = null;

            puntaje.reiniciar();

            ganador[0] = 0;
            ganador[1] = 0;
            ganador[2] = 0;

            vira = null;
        }

        public void asigVira(Carta vira)
        {
            this.vira = vira;
        }

        public void iniciar(PuntajeP puntajeP)
        {
            for (int i = 0; i < 3; i++)
            {
                mostrarPuntaje();
                puerto.actualizarPuntosTruco(puntaje.truco);
                puerto.actualizarPuntosEnvido(puntaje.envido);

                for (int j = 0; j < 4; j++)
                {
                    mostrarMesa();

                    Console.WriteLine();
                    Console.WriteLine("< TURNO JUGADOR " + turno.turno.id + " >");

                    switch (turno.turno.id)
                    {
                        case "A":
                            a = turno.turno.jugarTurno(i,puntaje,jb,ref rendirse);
                            turno.turno = jb;
                            break;
                        case "B":
                            b = turno.turno.jugarTurno(i,puntaje,jc,ref rendirse);
                            turno.turno = jc;
                            break;
                        case "C":
                            c = turno.turno.jugarTurno(i,puntaje,jd,ref rendirse);
                            turno.turno = jd;
                            break;
                        case "D":
                            d = turno.turno.jugarTurno(i,puntaje,ja,ref rendirse);
                            turno.turno = ja;
                            break;
                    }

                    if (rendirse != 0)
                        break;
                }

                if (rendirse != 0)
                    break;

                determinarGanador(i);

                a = null;
                b = null;
                c = null;
                d = null;

            }

            determinarGanadorR(puntajeP);
        }

        public void determinarGanadorR(PuntajeP puntajeP)
        {
            int ganador = 0;

            if(rendirse != 0)
            {
                if (rendirse == 1)
                    ganador = 2;
                else
                    ganador = 1;
            }
            else
            {

            }

            if (ganador == 1)
                puntajeP.equipoAC += puntaje.truco;
            else
                puntajeP.equipoBD += puntaje.truco;


            Console.WriteLine();
            Console.WriteLine("!!!LOS GANADORES DE LA RONDA SON EL EQUIPO " + ganador + "!!!");
        }

        public void mostrarMesa()
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
        }

        public void mostrarPuntaje()
        {
            Console.WriteLine();
                Console.WriteLine("<<< PUNTAJE DE LA RONDA >>>");
                Console.WriteLine("Puntaje truco: " + puntaje.truco);
                Console.WriteLine("Puntaje envido: " + puntaje.envido);
        }

        public void determinarGanador(int i)
        {
            if (a.valor(vira) > c.valor(vira))
            {
                if (b.valor(vira) > d.valor(vira))
                {
                    if (a.valor(vira) > b.valor(vira))
                    {
                        ganador[i] = 1;
                        turno.turno = ja;
                    }
                    else if (a.valor(vira) < b.valor(vira))
                    {
                        ganador[i] = 2;
                        turno.turno = jb;
                    }
                    else
                    {
                        ganador[i] = 0;
                        turno.turno = jb;
                    }
                }
                else
                {
                    if (a.valor(vira) > d.valor(vira))
                    {
                        ganador[i] = 1;
                        turno.turno = ja;
                    }
                    else if (a.valor(vira) < d.valor(vira))
                    {
                        ganador[i] = 2;
                        turno.turno = jd;
                    }
                    else
                    {
                        ganador[i] = 0;
                        turno.turno = jd;
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
                        turno.turno = jc;
                    }
                    else if (c.valor(vira) < b.valor(vira))
                    {
                        ganador[i] = 2;
                        turno.turno = jb;
                    }
                    else
                    {
                        ganador[i] = 0;
                        turno.turno = jc;
                    }
                }
                else
                {
                    if (c.valor(vira) > d.valor(vira))
                    {
                        ganador[i] = 1;
                        turno.turno = jc;
                    }
                    else if (c.valor(vira) < d.valor(vira))
                    {
                        ganador[i] = 2;
                        turno.turno = jd;
                    }
                    else
                    {
                        ganador[i] = 0;
                        turno.turno = jd;
                    }
                }
            }

        
            if(ganador[i] == 0)
                if(i == 0)
                {
                    i++;
                }
                else if(i == 1)
                {
                    ganador[1] = ganador[0];
                }
                else if(i == 2)
                {
                    ganador[2] = ganador[0];
                }

            mostrarMesa();

            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("GANADOR FASE " + (i + 1) + ": Equipo " + ganador[i]);
            Console.WriteLine("**************************************");
        }
    }
}
