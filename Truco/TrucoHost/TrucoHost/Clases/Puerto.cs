using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoHost.Clases
{
    class Puerto
    {
        private SerialPort puertoSalida = new SerialPort();
        private SerialPort puertoEntrada = new SerialPort();
        static public bool pideTruco;
        static public bool pideEnvido;
        static public bool quiero;
        static public bool noQuiero;
        static public int cartaRecibida;
        static public string emisor;
        static public bool recibido;

        public Puerto()
        {

            Console.WriteLine("el puerto ha sido creado");

            puertoSalida.BaudRate = 9600;
            puertoSalida.DataBits = 8;
            puertoSalida.Parity = Parity.None;
            puertoSalida.StopBits = StopBits.One;
            puertoSalida.Handshake = Handshake.None;
            puertoSalida.PortName = "COM2";


            puertoEntrada.BaudRate = 9600;
            puertoEntrada.DataBits = 8;
            puertoEntrada.Parity = Parity.None;
            puertoEntrada.StopBits = StopBits.One;
            puertoEntrada.Handshake = Handshake.None;
            puertoEntrada.PortName = "COM3";



            puertoEntrada.DataReceived += new SerialDataReceivedEventHandler(llegaronDatos); //coloco la interrupcion de entrada de datos

            puertoSalida.Open();
            puertoEntrada.Open();

        }









        //ENTRADA DE DATOS

        private static void llegaronDatos(object sender, SerialDataReceivedEventArgs e)
        {
            recibido = false;

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            subTrama(indata);
            Console.Write(indata);
            
        }


        private static void subTrama(string trama)
        {
            if (!trama[1].Equals('S'))
            {
                if (trama[0].Equals('C'))
                {
                    tramaCanto(trama);
                }
                else if (trama[0].Equals('L'))
                {
                    tramaLogica(trama);
                }
            }

        }



        private static void tramaCanto(string trama)
        {
            if (trama[3].Equals('T'))
            {
                pideTruco = true;
            }
            else if (trama[3].Equals('N'))
            {
                noQuiero = true;
            }
            else if (trama[3].Equals('E'))
            {
                pideEnvido = true;
            }
            else if (trama[3].Equals('Q'))
            {
                quiero = true;
            }

            Console.WriteLine(pideTruco);
            Console.WriteLine(noQuiero);
            Console.WriteLine(pideEnvido);
            Console.WriteLine(quiero);
            Console.WriteLine("**************************");
        }


        private static void tramaLogica(string trama)
        {
            if (trama[3].Equals('C'))
            {
                try
                {
                    cartaRecibida = int.Parse(trama.Substring(4, 2));
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("error al convertir el dato en la funcion tramaLogica");
                }
            }
        }








        public static string CharCombine(char c0, char c1, char c2)
        {
            // Combine chars into array
            char[] arr = new char[3];
            arr[0] = c0;
            arr[1] = c1;
            arr[2] = c2;
            // Return new string key
            return new string(arr);
        }




        public void prueba(string mensaje)
        {
            puertoSalida.Write(mensaje);
        }









        //SALIDA DE DATOS 


        public void turno(string jugador)
        {
            puertoSalida.Write("LSTT" + jugador);
        }


        public void truco(string destino)
        {
            puertoSalida.Write("CSTT" + destino);
        }

        public void envido(string destino)
        {
            puertoSalida.Write("CSTE" + destino);
        }


        public void terminarPartida(int equipo)
        {
            if (equipo == 1)
            {
                puertoSalida.Write("$$STAC########%%");
            }
            else
            {
                puertoSalida.Write("$$STBD########%%");
            }

            pideTruco = false;
        }


        public void actualizarPuntaje(int puntajeEquipo1, int puntajeEquipo2)
        {
            puertoSalida.Write("LSTP" + puntajeEquipo1.ToString() + puntajeEquipo2.ToString());
        }

        public void finalizarjuego(int equipoGanador)
        {
            puertoSalida.Write("LSTF" + equipoGanador.ToString());
        }


        public void carta(string carta)
        {
            puertoSalida.Write("LSTC" + carta);
        }


        public void recogerCartas()
        {
            puertoSalida.Write("LSTRC");
        }



        public void repartir(string destino, string cartas)
        {
            puertoSalida.Write("I" + destino + cartas);
        }


       public void repartirVira(string carta)
        {
            puertoSalida.Write("ITV"+carta);
        }

        public void actualizarPuntosEnvido(int valorPuntos)
        {
            puertoSalida.Write("LSTPE"+valorPuntos.ToString());
        }

        public void actualizarPuntosTruco(int valorPuntos)
        {
            puertoSalida.Write("LSTPT" + valorPuntos.ToString());
        }

        public void limpieza()
        {
            pideTruco = false;
            pideEnvido = false;
            quiero = false;
            noQuiero = false;
            cartaRecibida = 0;
            recibido = true;
        }

    }
}
