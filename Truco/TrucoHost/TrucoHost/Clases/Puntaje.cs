using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Puntaje
    {
        private int equipoAC;
        private int equipoBD;
        private int ronda;
        private int envido;

        public Puntaje()
        {
            equipoAC = 0;
            equipoBD = 0;
            ronda = 1;
            envido = 0;
        }

        public void reiniciar()
        {
            ronda = 1;
            envido = 0;
        }

        public int getequipoAC()
        {
            return equipoAC;
        }

        public int getequipoBD()
        {
            return equipoBD;
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
            if (equipoAC > 23 || equipoBD > 23)
                return true;
            else
                return false;
        }

        public int ganador()
        {
            if (equipoAC > equipoBD)
                return 1;
            else if (equipoAC < equipoBD)
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

        public int sum_ronda_equipoAC()
        {
            equipoAC += ronda;
            return equipoAC;
        }

        public int sum_ronda_equipoBD()
        {
            equipoBD += ronda;
            return equipoBD;
        }

        public int sum_envido_equipoAC()
        {
            equipoAC += ronda;
            return equipoAC;
        }

        public int sum_envido_equipoBD()
        {
            equipoBD += ronda;
            return equipoBD;
        }

        public int sum_ronda_envido_equipoAC()
        {
            equipoAC += ronda + envido;
            return equipoAC;
        }

        public int sum_ronda_envido_equipoBD()
        {
            equipoBD += ronda + envido;
            return equipoBD;
        }

    }
}
