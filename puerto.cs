using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace turnos
{
    public class puerto
    {
        private SerialPort puertoSalida = new SerialPort();
        private SerialPort puertoEntrada = new SerialPort();
        static public bool pideTruco;
        static public bool pideRetruco;
        static public bool pideEnvido;
        static public bool respuestaEnvido;
        static public string carta;

        public puerto()
        {
            pideTruco = false;
            carta = "###";

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
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if(!indata[2].Equals('S')){
              evaluarTruco(indata);
              obtenerCarta(indata);
            }
            Console.Write(indata);
        }


        private static void evaluarEnvido(string trama)
        {
            if (trama[7].Equals('S'))
            {
                pideEnvido = true;
            }
            else pideEnvido = false;
        }


        private static void evaluarRespuestaEnvido(string trama)
        {
            if (trama[8].Equals('S'))
            {
                respuestaEnvido = true;
            }
            else respuestaEnvido = false;
        }

        private static void evaluarTruco(string trama)
        {
            if (trama[9].Equals('S'))
            {
                pideTruco = true;
            }
            else pideTruco = false;
        }


        private static void evaluarRetruco(string trama)
        {
            if (trama[10].Equals('S'))
            {
                pideRetruco = true;
            }
            else pideRetruco = false;
        }

        private static void obtenerCarta(string trama)   //11 12 13
        {
            if (!trama[12].Equals('#'))
            {
                if (!trama[11].Equals('#'))
                {
                    carta = CharCombine(trama[11], trama[12], trama[13]);
                }
                else
                {
                    carta = CharCombine('#', trama[12], trama[13]);
                }
            }
            else
                carta = CharCombine('#', '#', '#');
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
            puertoSalida.WriteLine(mensaje);
            pideTruco = false;
        }









        //SALIDA DE DATOS 


        public void turno(string destino)
        {
            puertoSalida.WriteLine("$$S" + destino + "SGA#######%%");
            pideTruco = false;
        }




        public void terminarPartida(int equipo)
        {
            if (equipo == 1)
            {
                puertoSalida.WriteLine("$$STAC########%%");
            }
            else
            {
                puertoSalida.WriteLine("$$STBD########%%");
            }

            pideTruco = false;
        }

      /*  public void repartir(string destino, Carta carta1, Carta carta2, Carta carta3)
        {
            puertoSalida.WriteLine("$$S" + destino + "SGD####" + carta1.ToString() + "%%");
            puertoSalida.WriteLine("$$S" + destino + "SGD####" + carta2.ToString() + "%%");
            puertoSalida.WriteLine("$$S" + destino + "SGD####" + carta3.ToString() + "%%");
            pideTruco = false;
        }*/



    }

}
