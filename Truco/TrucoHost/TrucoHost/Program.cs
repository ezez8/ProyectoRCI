using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoHost.Clases;

namespace TrucoHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            mazo.reiniciar();
            while (true)
            {
                Console.WriteLine("-------------------------------------------------");
                mazo.toString();
                Console.ReadKey();
                mazo.getCarta();
            }
            

        }
    }
}
