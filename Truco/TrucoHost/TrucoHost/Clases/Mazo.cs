using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Mazo
    {
        List<Carta> cartas;
        Random random;

        public Mazo()
        {
            cartas = new List<Carta>();
            random = new Random();
        }

        public void reiniciar()
        {
            cartas.Clear();

            cartas.Add(new Carta("O", "#1"));
            cartas.Add(new Carta("O", "#2"));
            cartas.Add(new Carta("O", "#3"));
            cartas.Add(new Carta("O", "#4"));
            cartas.Add(new Carta("O", "#5"));
            cartas.Add(new Carta("O", "#6"));
            cartas.Add(new Carta("O", "#7"));
            cartas.Add(new Carta("O", "10"));
            cartas.Add(new Carta("O", "11"));
            cartas.Add(new Carta("O", "12"));

            cartas.Add(new Carta("C", "#1"));
            cartas.Add(new Carta("C", "#2"));
            cartas.Add(new Carta("C", "#3"));
            cartas.Add(new Carta("C", "#4"));
            cartas.Add(new Carta("C", "#5"));
            cartas.Add(new Carta("C", "#6"));
            cartas.Add(new Carta("C", "#7"));
            cartas.Add(new Carta("C", "10"));
            cartas.Add(new Carta("C", "11"));
            cartas.Add(new Carta("C", "12"));

            cartas.Add(new Carta("E", "#1"));
            cartas.Add(new Carta("E", "#2"));
            cartas.Add(new Carta("E", "#3"));
            cartas.Add(new Carta("E", "#4"));
            cartas.Add(new Carta("E", "#5"));
            cartas.Add(new Carta("E", "#6"));
            cartas.Add(new Carta("E", "#7"));
            cartas.Add(new Carta("E", "10"));
            cartas.Add(new Carta("E", "11"));
            cartas.Add(new Carta("E", "12"));

            cartas.Add(new Carta("B", "#1"));
            cartas.Add(new Carta("B", "#2"));
            cartas.Add(new Carta("B", "#3"));
            cartas.Add(new Carta("B", "#4"));
            cartas.Add(new Carta("B", "#5"));
            cartas.Add(new Carta("B", "#6"));
            cartas.Add(new Carta("B", "#7"));
            cartas.Add(new Carta("B", "10"));
            cartas.Add(new Carta("B", "11"));
            cartas.Add(new Carta("B", "12"));

        }

        public Carta getCarta()
        {
            int i = random.Next(cartas.Count);
            Carta carta = cartas.ElementAt(i);
            cartas.RemoveAt(i);
            return carta;
        }

        public void toString()
        {
            int i = 0;
            foreach (Carta carta in cartas) {
                i++;
                Console.WriteLine(i + " >> " + carta.toString());
            }
        }
    }
}
