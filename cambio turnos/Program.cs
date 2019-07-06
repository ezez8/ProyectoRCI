using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnos
{
    class Program
    {
        static void Main(string[] args)
        {
            puerto sp = new puerto();
            sp.turnoA();
            sp.turnoB();
            sp.turnoC();
            sp.turnoD();
            Console.ReadKey();
        }
    }
}
