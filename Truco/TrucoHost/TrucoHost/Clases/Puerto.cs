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
        private SerialPort puerto = new SerialPort();
        public bool pideTruco;
        public bool pideEnvido;
        public bool quiero;
        public bool noQuiero;
        public int cartaRecibida;
        public string emisor;
        public bool recibido;

        public Puerto()
        {

            Console.WriteLine("el puerto ha sido creado");

            puerto.BaudRate = 9600;
            puerto.DataBits = 8;
            puerto.Parity = Parity.None;
            puerto.StopBits = StopBits.One;
            puerto.Handshake = Handshake.None;
            puerto.PortName = "COM1";




            puerto.DataReceived += new SerialDataReceivedEventHandler(llegaronDatos); //coloco la interrupcion de entrada de datos

            puerto.Open();

            pideTruco = false;
            pideEnvido = false;
            quiero = false;
            noQuiero = false;
            cartaRecibida = 0;
            recibido = true;

        }









        //ENTRADA DE DATOS

        private void llegaronDatos(object sender, SerialDataReceivedEventArgs e)
        {
            recibido = true;

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            subTrama(indata);
            Console.Write(indata);
            
        }


        private void subTrama(string trama)
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



        private void tramaCanto(string trama)
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


        private void tramaLogica(string trama)
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
            puerto.Write(mensaje);
        }









        //SALIDA DE DATOS 


        public void turno(string jugador)
        {
            puerto.Write("LSTT" + jugador);
        }


        public void truco(string destino)
        {
            puerto.Write("CS"+destino+"T");
        }

        public void envido(string destino)
        {
            puerto.Write("CS"+destino+"E");
        }


        public void terminarPartida(int equipo)
        {
            if (equipo == 1)
            {
                puerto.Write("$$STAC########%%");
            }
            else
            {
                puerto.Write("$$STBD########%%");
            }

            pideTruco = false;
        }


        public void actualizarPuntaje(int puntajeEquipo1, int puntajeEquipo2)
        {
            puerto.Write("LSTP" + puntajeEquipo1.ToString() + puntajeEquipo2.ToString());
        }

        public void finalizarjuego(int equipoGanador)
        {
            puerto.Write("LSTF" + equipoGanador.ToString());
        }


        public void carta(string carta,string propietario)
        {
            puerto.Write("LSTC" + carta+propietario);
        }


        public void recogerCartas()
        {
            puerto.Write("LSTRC");
        }



        public void repartir(string destino, string cartas)
        {
            puerto.Write("I" + destino + cartas);
        }


       public void repartirVira(string carta)
        {
            puerto.Write("ITV"+carta);
        }

        public void actualizarPuntosEnvido(int valorPuntos)
        {
            puerto.Write("LSTPE"+valorPuntos.ToString());
        }

        public void actualizarPuntosTruco(int valorPuntos)
        {
            puerto.Write("LSTPT" + valorPuntos.ToString());
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
