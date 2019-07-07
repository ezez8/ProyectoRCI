using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace Envío_y_recepción_de_datos
{
    public partial class Form1 : Form
    {
        //------------DELEGADO ???-------------------
        private delegate void DelegadoAcceso(string accion);
        //------------Strings donde se enviarán y recibirán los datos----------
        private string strBufferIn;
        private string strBufferOut;

        public Form1()
        {
            InitializeComponent();
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            //---------AQUÍ SE MANEJA EL MENSAJE RECIBIDO-------------
            TxtDatosRecibidos.Text = strBufferIn;
            //--------SIMULACIÓN DE PEDIR ENVIDO---------------
            if(strBufferIn[7] == 'S')
            {
                EnviarDatos("$$STSG#S######%%");
            }
            //--------------------------------------------------------
        }

        //------------DELEGADO ???-------------------
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }

        //-----Se inicializan los buffers y se desabilitan los botones 'CONECTAR' y 'ENVIAR DATOS'
        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;
        }

        
        private void BtnBuscarPuertos_Click(object sender, EventArgs e)
        {
            //Se buscan los puertos disponibles de la computadora
            string[] PuertosDisponibles = SerialPort.GetPortNames();

            //Se limpia el comboBox
            CboPuertos.Items.Clear();

            //Se llena el comboBox con los puertos disponibles
            foreach (string puerto in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto);
            }

            //Si hay puertos disponibles se habilita 'CONECTAR' si no se avisa que no hay puertos disponibles
            if(CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                MessageBox.Show("SELECCIONA UN PUERTO");
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO SE DETECTARON PUERTOS DISPONIBLES");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "                     ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //'CONECTAR' configura el puerto, lo abre, cambia a 'DESCONECTAR' y habilita el botón 'Enviar Datos'
                if(BtnConectar.Text == "CONECTAR")
                {
                    SpPuertos.BaudRate = Int32.Parse(CboBaudRate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = CboPuertos.Text;

                    try
                    {
                        SpPuertos.Open();
                        BtnConectar.Text = "DESCONECTAR";
                        BtnEnviarDatos.Enabled = true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                //'DESCONECTAR' cierra el puerto, cambia a 'CONECTAR' y desabilita el botón 'Enviar Datos'
                else if(BtnConectar.Text == "DESCONECTAR")
                {
                    SpPuertos.Close();
                    BtnConectar.Text = "CONECTAR";
                    BtnEnviarDatos.Enabled = false;
                }

            }
            catch(Exception ex)
            {
                //Si hay algún problema conectándose se muestra por pantalla el error
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            //Se llena el buffer de salida y se envían los datos
            try
            {
                //---------AQUÍ SE MANEJA EL MENSAJE ENVIADO-------------
                SpPuertos.DiscardOutBuffer();
                strBufferOut = TxtDatosEnviados.Text;
                SpPuertos.Write(strBufferOut);
                //-------------------------------------------------------
            }
            catch (Exception ex)
            {
                //Si hay algún problema enviando datos se muestra por pantalla el error
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void EnviarDatos(string msg)
        {
            //Se llena el buffer de salida y se envían los datos
            try
            {
                //---------AQUÍ SE MANEJA EL MENSAJE ENVIADO-------------
                SpPuertos.DiscardOutBuffer();
                strBufferOut = msg;
                SpPuertos.Write(msg);
                //-------------------------------------------------------
            }
            catch (Exception ex)
            {
                //Si hay algún problema enviando datos se muestra por pantalla el error
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            //----Se recibe el mensaje a través de DELEGADOS ???--------------
            AccesoInterrupcion(SpPuertos.ReadExisting());

            /*string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtDatosRecibidos.Text = Data_in;*/
        }

        //------------NO HACE NADA PERO NO SE PUEDE QUITAR

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
