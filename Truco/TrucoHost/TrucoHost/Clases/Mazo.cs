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

            cartas.Add(new Carta("O", "#1","01"));
            cartas.Add(new Carta("O", "#2","02"));
            cartas.Add(new Carta("O", "#3","03"));
            cartas.Add(new Carta("O", "#4","04"));
            cartas.Add(new Carta("O", "#5","05"));
            cartas.Add(new Carta("O", "#6","06"));
            cartas.Add(new Carta("O", "#7","07"));
            cartas.Add(new Carta("O", "10","08"));
            cartas.Add(new Carta("O", "11","09"));
            cartas.Add(new Carta("O", "12","10"));

            cartas.Add(new Carta("C", "#1","10"));
            cartas.Add(new Carta("C", "#2","11"));
            cartas.Add(new Carta("C", "#3","12"));
            cartas.Add(new Carta("C", "#4","14"));
            cartas.Add(new Carta("C", "#5","15"));
            cartas.Add(new Carta("C", "#6","16"));
            cartas.Add(new Carta("C", "#7","17"));
            cartas.Add(new Carta("C", "10","18"));
            cartas.Add(new Carta("C", "11","19"));
            cartas.Add(new Carta("C", "12","20"));

            cartas.Add(new Carta("E", "#1","21"));
            cartas.Add(new Carta("E", "#2","22"));
            cartas.Add(new Carta("E", "#3","23"));
            cartas.Add(new Carta("E", "#4","24"));
            cartas.Add(new Carta("E", "#5","25"));
            cartas.Add(new Carta("E", "#6","26"));
            cartas.Add(new Carta("E", "#7","27"));
            cartas.Add(new Carta("E", "10","28"));
            cartas.Add(new Carta("E", "11","29"));
            cartas.Add(new Carta("E", "12","30"));

            cartas.Add(new Carta("B", "#1","31"));
            cartas.Add(new Carta("B", "#2","32"));
            cartas.Add(new Carta("B", "#3","33"));
            cartas.Add(new Carta("B", "#4","34"));
            cartas.Add(new Carta("B", "#5","35"));
            cartas.Add(new Carta("B", "#6","36"));
            cartas.Add(new Carta("B", "#7","37"));
            cartas.Add(new Carta("B", "10","38"));
            cartas.Add(new Carta("B", "11","39"));
            cartas.Add(new Carta("B", "12","40"));

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
