using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Carta
    {
        Numeracion numeracion;
        Palo palo;

        public Carta(Numeracion numeracion, Palo palo)
        {
            this.numeracion = numeracion;
            this.palo = palo;

            Console.WriteLine(palo.ToString() + " | " + numeracion.ToString());
        }
    }
}
