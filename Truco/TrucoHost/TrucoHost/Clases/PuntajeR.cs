using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class PuntajeR
    {
        public int truco;
        public int envido;

        public PuntajeR()
        {
            truco = 1;
            envido = 0;
        }

        public void reiniciar()
        {
            truco = 1;
            envido = 0;
        }
    }
}
