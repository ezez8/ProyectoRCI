using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Puntaje
    {
        private int equipo1;
        private int equipo2;
        private int ronda;
        private int envido;

        public Puntaje()
        {
            equipo1 = 0;
            equipo2 = 0;
            ronda = 1;
            envido = 0;
        }

        public void reiniciar()
        {
            ronda = 1;
            envido = 0;
        }

        public int getEquipo1()
        {
            return equipo1;
        }

        public int getEquipo2()
        {
            return equipo2;
        }

        public int getRonda()
        {
            return ronda;
        }

        public int getEnvido()
        {
            return envido;
        }

        public bool gameOver()
        {
            if (equipo1 > 23 || equipo2 > 23)
                return true;
            else
                return false;
        }

        public int ganador()
        {
            if (equipo1 > equipo2)
                return 1;
            else if (equipo1 < equipo2)
                return 2;
            else
                return 0;

        }

        public int aumRonda(int aum)
        {
            ronda += aum;
            return ronda;
        }

        public int aumEnvido(int aum)
        {
            envido += aum;
            return envido;
        }

        public int sum_ronda_equipo1()
        {
            equipo1 += ronda;
            return equipo1;
        }

        public int sum_ronda_equipo2()
        {
            equipo2 += ronda;
            return equipo2;
        }

        public int sum_envido_equipo1()
        {
            equipo1 += ronda;
            return equipo1;
        }

        public int sum_envido_equipo2()
        {
            equipo2 += ronda;
            return equipo2;
        }

        public int sum_ronda_envido_equipo1()
        {
            equipo1 += ronda + envido;
            return equipo1;
        }

        public int sum_ronda_envido_equipo2()
        {
            equipo2 += ronda + envido;
            return equipo2;
        }

    }
}
