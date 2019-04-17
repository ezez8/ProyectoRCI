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

        public Mazo()
        {
            cartas = new List<Carta>();

            foreach (Palo palo in Enum.GetValues(typeof(Palo)))
                foreach (Numeracion numeracion in Enum.GetValues(typeof(Numeracion)))
                    cartas.Add(new Carta(numeracion, palo));
        }
    }
}
