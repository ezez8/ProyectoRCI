using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Jugador
    {
        public string id;
        public Carta a;
        public Carta b;
        public Carta c;

        public Puerto puerto;

        public Jugador(string id, Puerto puerto)
        {
            this.id = id;
            this.puerto = puerto;
        }

        public void repartir(Carta a,Carta b,Carta c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void reiniciar()
        {
            this.a = null;
            this.b = null;
            this.c = null;
        }

        public Carta jugarTurno(int i, PuntajeR puntaje, Jugador jugadorDer, ref int rendirse)
        {
            Carta auxc;
            do {

                Console.WriteLine("SELECCIONA UNA CARTA JUGADOR " + id);
                if (a != null)
                    Console.WriteLine("1. " + a.toString());
                if (b != null)
                    Console.WriteLine("2. " + b.toString());
                if (c != null)
                    Console.WriteLine("3. " + c.toString());
                if(puntaje.truco == 1)
                    Console.WriteLine("4. TRUCO");
                if(i == 0)
                    Console.WriteLine("5. ENVIDO");

                Console.Write(">> ");
                Console.ReadLine();

                puerto.turno(id);
                switch (readPuerto())
                {
                    case "1":
                        auxc = a;
                        a = null;
                        break;
                    case "2":
                        auxc = b;
                        b = null;
                        break;
                    case "3":
                        auxc = c;
                        c = null;
                        break;
                    case "4":
                        jugadorDer.responderTruco(puntaje,this, ref rendirse);
                        auxc = null;
                        break;
                    case "5":
                        jugadorDer.responderEnvido(puntaje);
                        auxc = null;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("<<ERROR DEBE SELECCIONAR UNA CARTA O TRUCO O ENVIDO!!!>>");
                        Console.WriteLine();
                        auxc = null;
                        break;
                }

                if (rendirse != 0)
                    break;

            } while (auxc == null);

            puerto.carta(auxc.id);

            return auxc;
        }

        public string readPuerto()
        {
            
            while (!puerto.recibido) { }

            string resp = "";

            if (puerto.cartaRecibida != 0)
            {
                if (puerto.cartaRecibida == Int32.Parse(a.id))
                    resp = "1";
                else if(puerto.cartaRecibida == Int32.Parse(b.id))
                    resp = "2";
                else if (puerto.cartaRecibida == Int32.Parse(c.id))
                    resp = "3";
            }
            else if (puerto.pideTruco)
            {
                resp = "4";
            }
            else if (puerto.pideEnvido)
            {
                resp = "5";
            }
            else if (puerto.quiero)
            {
                resp = "6";
            }
            else if (puerto.noQuiero)
            {
                resp = "7";
            }

            puerto.limpieza();

            return resp;
        }

        public void responderEnvido(PuntajeR puntaje)
        {
            string resp;

            do
            {

                Console.WriteLine();
                Console.WriteLine("RESPUESTA AL ENVIDO JUGADOR " + id);
                Console.WriteLine("6. QUIERO");
                Console.WriteLine("7. NO QUIERO");

                Console.Write(">> ");

                puerto.envido(id);
                resp = readPuerto();

                switch (resp)
                {
                    case "6":
                        puntaje.envido = 2;
                        break;
                    case "7":
                        puntaje.envido = 1;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("<<ERROR DEBE SELECCIONAR UNA OPCION!!!>>");
                        Console.WriteLine();
                        resp = "0";
                        break;
                }

            } while (resp == "0");
        }

        public void responderTruco(PuntajeR puntaje,Jugador jugadorIzq,ref int rendirse)
        {
            string resp;

            do {

                Console.WriteLine();
                Console.WriteLine("RESPUESTA AL TRUCO JUGADOR " + id);
                Console.WriteLine("6. QUIERO");
                Console.WriteLine("7. NO QUIERO");
                Console.WriteLine("4. QUIERO Y RETRUCO");

                Console.Write(">> ");

                puerto.truco(id);
                resp = readPuerto();

                switch (resp)
                {
                    case "6":
                        puntaje.truco = 3;
                        break;
                    case "7":
                        if (id == "A" || id == "C")
                            rendirse = 1;
                        else
                            rendirse = 2;
                        break;
                    case "4":
                        puntaje.truco = 3;
                        jugadorIzq.responderRetruco(puntaje,this, ref rendirse);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("<<ERROR DEBE SELECCIONAR UNA OPCION!!!>>");
                        Console.WriteLine();
                        resp = "0";
                        break;
                }

            } while (resp == "0");
        }

        public void responderRetruco(PuntajeR puntaje, Jugador jugadorDer, ref int rendirse)
        {
            string resp;

            do
            {

                Console.WriteLine();
                Console.WriteLine("RESPUESTA AL RETRUCO JUGADOR " + id);
                Console.WriteLine("6. QUIERO");
                Console.WriteLine("7. NO QUIERO");
                Console.WriteLine("4. QUIERO Y VALE9");

                Console.Write(">> ");

                puerto.truco(id);
                resp = readPuerto();

                switch (resp)
                {
                    case "6":
                        puntaje.truco = 6;
                        break;
                    case "7":
                        if (id == "A" || id == "C")
                            rendirse = 1;
                        else
                            rendirse = 2;
                        break;
                    case "4":
                        puntaje.truco = 6;
                        jugadorDer.responderVale9(puntaje,this,ref rendirse);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("<<ERROR DEBE SELECCIONAR UNA OPCION!!!>>");
                        Console.WriteLine();
                        resp = "0";
                        break;
                }

            } while (resp == "0");
        }

        public void responderVale9(PuntajeR puntaje, Jugador jugadorIzq, ref int rendirse)
        {
            string resp;

            do
            {

                Console.WriteLine();
                Console.WriteLine("RESPUESTA AL VALE9 JUGADOR " + id);
                Console.WriteLine("6. QUIERO");
                Console.WriteLine("7. NO QUIERO");
                Console.WriteLine("4. QUIERO Y VALE JUEGO");

                Console.Write(">> ");

                puerto.truco(id);
                resp = readPuerto();

                switch (resp)
                {
                    case "6":
                        puntaje.truco = 9;
                        break;
                    case "7":
                        if (id == "A" || id == "C")
                            rendirse = 1;
                        else
                            rendirse = 2;
                        break;
                    case "4":
                        puntaje.truco = 9;
                        jugadorIzq.responderValeJuego(puntaje,this, ref rendirse);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("<<ERROR DEBE SELECCIONAR UNA OPCION!!!>>");
                        Console.WriteLine();
                        resp = "0";
                        break;
                }

            } while (resp == "0");
        }

        public void responderValeJuego(PuntajeR puntaje, Jugador jugadorIzq, ref int rendirse)
        {
            string resp;

            do
            {

                Console.WriteLine();
                Console.WriteLine("RESPUESTA AL VALE JUEGO JUGADOR " + id);
                Console.WriteLine("6. QUIERO");
                Console.WriteLine("7. NO QUIERO");

                Console.Write(">> ");

                puerto.truco(id);
                resp = readPuerto();

                switch (resp)
                {
                    case "6":
                        puntaje.truco = 24;
                        break;
                    case "7":
                        if (id == "A" || id == "C")
                            rendirse = 1;
                        else
                            rendirse = 2;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("<<ERROR DEBE SELECCIONAR UNA OPCION!!!>>");
                        Console.WriteLine();
                        resp = "0";
                        break;
                }

            } while (resp == "0");
        }
    }
}
