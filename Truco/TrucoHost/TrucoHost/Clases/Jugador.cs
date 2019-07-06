using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Jugador
    {
        public char id;
        public Carta a;
        public Carta b;
        public Carta c;

        public Jugador(char id)
        {
            this.id = id;
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

        public Carta jugarCarta()
        {
            Console.WriteLine("Selecciona una carta jugador " + id);
            if (a != null)
                Console.WriteLine("1. " + a.toString());
            if (b != null)
                Console.WriteLine("2. " + b.toString());
            if (c != null)
                Console.WriteLine("3. " + c.toString());
            Console.WriteLine(">> ");

            Carta auxc;

            switch (Console.ReadLine())
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
                default:
                    auxc = null;
                    break;
            }

            return auxc;
        }
    }
}
