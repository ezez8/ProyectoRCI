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

            foreach (Palo palo in Enum.GetValues(typeof(Palo)))
                foreach (Numeracion numeracion in Enum.GetValues(typeof(Numeracion)))
                    cartas.Add(new Carta(numeracion, palo));
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
