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

        public puerto()
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

            puertoEntrada.ReadTimeout = 500;
        }





        private static void llegaronDatos(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
        }



        public void turnoA()
        {
            puertoSalida.WriteLine("$$SASGA#######%%");
        }

        public void turnoB()
        {
            puertoSalida.WriteLine("$$SBSGB#######%%");
        }

        public void turnoC()
        {
            puertoSalida.WriteLine("$$SCSGC#######%%");
        }

        public void turnoD()
        {
            puertoSalida.WriteLine("$$SDSGD#######%%");
        }

    }

}
