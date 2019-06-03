using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Carta
    {
        private Numeracion numeracion;
        private Palo palo;

        public Carta(Numeracion numeracion, Palo palo)
        {
            this.numeracion = numeracion;
            this.palo = palo;
        }

        public string toString()
        {
            return palo.ToString() + " | " + numeracion.ToString();
        }
    }
}
