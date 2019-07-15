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
using System.Diagnostics;

namespace TrucoClient
{
    public partial class TrucoForm : Form
    {
        public TrucoForm()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\green-background.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //TxtLastData.Enabled = false;
        }
        
        //-----Se inicializan los buffers y se desabilitan los botones 'CONECTAR' y 'ENVIAR DATOS'
        private void TrucoForm_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;
            BtnNext.Enabled = false;

            PbCartaA.Image = Image.FromFile("PLACE.png");
            PbCartaB.Image = Image.FromFile("PLACE.png");
            PbCartaC.Image = Image.FromFile("PLACE.png");
            PbCartaD.Image = Image.FromFile("PLACE.png");
        }

        //------------DELEGADO ???-------------------
        private delegate void DelegadoAcceso(string accion);
        //------------Strings donde se enviarán y recibirán los datos----------
        private string strBufferIn;
        private string strBufferOut;
        public string computadora;
        public string carta;
        public string ptosAC;
        public string ptosBD;
        public string ptosApuesta;
        public string ptosEnvido;

        //TrucoGame gameForm = new TrucoGame();

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            //---------AQUÍ SE MANEJA EL MENSAJE RECIBIDO-------------
            TxtDatosRecibidos.Text = strBufferIn;
            //gameForm.TxtLastData.Text = strBufferIn;
            
            if(strBufferIn[0] == 'I')
            {
                //SE ASUME QUE SE VA A REPARTIR
                if (strBufferIn[1] == computadora[0])
                {
                    //SI LAS CARTAS SON PARA MI SE MUESTRAN LAS CARTAS
                    for (int i = 2; i < 8; i++)
                    {
                        if (i == 2)
                        {
                            carta = "";
                            carta = carta + strBufferIn[i];
                        }

                        if (i == 3)
                        {
                            carta = carta + strBufferIn[i];
                            PbCarta1.Image = Image.FromFile(carta + ".png");
                            PbCarta1.Tag = carta;
                        }

                        if (i == 4)
                        {
                            carta = "";
                            carta = carta + strBufferIn[i];
                        }

                        if (i == 5)
                        {
                            carta = carta + strBufferIn[i];
                            PbCarta2.Image = Image.FromFile(carta + ".png");
                            PbCarta2.Tag = carta;
                                                    }

                        if (i == 6)
                        {
                            carta = "";
                            carta = carta + strBufferIn[i];
                        }

                        if (i == 7)
                        {
                            carta = carta + strBufferIn[i];
                            PbCarta3.Image = Image.FromFile(carta + ".png");
                            PbCarta3.Tag = carta;

                        }
                    }
                }
                if(strBufferIn[1] == 'T')
                {
                    carta = strBufferIn[3].ToString() + strBufferIn[4].ToString();
                    PbVira.Image = Image.FromFile(carta + ".png");
                    if(computadora[0] != 'A')
                    {
                        EnviarDatos(strBufferIn);
                    }
                }
                else
                {
                    //SI LAS CARTAS NO SON PARA MI SE REENVIA LA TRAMA
                    EnviarDatos(strBufferIn);
                }


            }else if (strBufferIn[0] == 'L')
            {
                if(strBufferIn[3] == 'R')
                {
                    PbCartaA.Image = Image.FromFile("PLACE.png");
                    PbCartaB.Image = Image.FromFile("PLACE.png");
                    PbCartaC.Image = Image.FromFile("PLACE.png");
                    PbCartaD.Image = Image.FromFile("PLACE.png");

                }

                else if (strBufferIn[3] == 'T')
                {
                    //SE MUESTRA EL BOMBILLITO DEL TURNO EN LA PANTALLA                
                    if (strBufferIn[4] == 'A')
                    {
                        PbTurnoA.Image = Image.FromFile("turno.png");

                        PbTurnoA.Visible = false;
                        PbTurnoB.Visible = false;
                        PbTurnoC.Visible = false;
                        PbTurnoD.Visible = false;


                        PbTurnoA.Visible = true;
                    }
                    if (strBufferIn[4] == 'B')
                    {
                        PbTurnoB.Image = Image.FromFile("turno.png");

                        PbTurnoA.Visible = false;
                        PbTurnoB.Visible = false;
                        PbTurnoC.Visible = false;
                        PbTurnoD.Visible = false;

                        PbTurnoB.Visible = true;
                    }
                    if (strBufferIn[4] == 'C')
                    {
                        PbTurnoC.Image = Image.FromFile("turno.png");

                        PbTurnoA.Visible = false;
                        PbTurnoB.Visible = false;
                        PbTurnoC.Visible = false;
                        PbTurnoD.Visible = false;

                        PbTurnoC.Visible = true;
                    }
                    if (strBufferIn[4] == 'D')
                    {
                        PbTurnoD.Image = Image.FromFile("turno.png");

                        PbTurnoA.Visible = false;
                        PbTurnoB.Visible = false;
                        PbTurnoC.Visible = false;
                        PbTurnoD.Visible = false;

                        PbTurnoD.Visible = true;
                    }

                    //SI ES TU TURNO JUEGAS 

                    if (computadora[0] == strBufferIn[4])
                    {
                        //SE HABILITAN LAS CARTAS
                        PbCarta1.Enabled = true;
                        PbCarta2.Enabled = true;
                        PbCarta3.Enabled = true;
                    }
                }
                else if(strBufferIn[3] == 'C')
                {
                   // TxtDatosRecibidos.Text = "Entré en C";

                    if(strBufferIn[6] == 'A')
                    {
                        carta = strBufferIn[4].ToString() + strBufferIn[5].ToString();
                        PbCartaA.Image = Image.FromFile(carta + ".png");
                    }
                    if (strBufferIn[6] == 'B')
                    {
                        carta = strBufferIn[4].ToString() + strBufferIn[5].ToString();
                        PbCartaB.Image = Image.FromFile(carta + ".png");
                    }
                    if (strBufferIn[6] == 'C')
                    {
                        carta = strBufferIn[4].ToString() + strBufferIn[5].ToString();
                        PbCartaC.Image = Image.FromFile(carta + ".png");
                    }
                    if (strBufferIn[6] == 'D')
                    {
                        carta = strBufferIn[4].ToString() + strBufferIn[5].ToString();
                        PbCartaD.Image = Image.FromFile(carta + ".png");
                    }
                }

                if (strBufferIn[3] == 'P' && strBufferIn[4] == 'T')
                {
                    if (strBufferIn.Length == 6)
                    {
                        ptosApuesta = strBufferIn[5].ToString();
                        LblPuntosApuesta.Text = ptosApuesta;
                    }
                    if (strBufferIn.Length == 7)
                    {
                        ptosApuesta = strBufferIn[5].ToString() + strBufferIn[6].ToString();
                        LblPuntosApuesta.Text = ptosApuesta;
                    }
                }
                else if (strBufferIn[3] == 'P' && strBufferIn[4] == 'E')
                {
                    ptosEnvido = strBufferIn[5].ToString();
                    LblPuntosEnvido.Text = ptosEnvido;
                }
                else if (strBufferIn[3] == 'P')
                {
                    ptosAC = strBufferIn[4].ToString() + strBufferIn[5].ToString();
                    ptosBD = strBufferIn[6].ToString() + strBufferIn[7].ToString();
                    LblPuntosAC.Text = ptosAC;
                    LblPuntosBD.Text = ptosBD;
                }

                if (computadora[0] != 'A')
                {
                    EnviarDatos(strBufferIn);
                }
            }

            //MessageBox.Show("Limpiando buffer");
            strBufferIn = "";

            //--------SIMULACIÓN DE PEDIR ENVIDO---------------
            /* if (strBufferIn[7] == 'S')
             {
                 EnviarDatos("$$STSG#S######%%");
             }*/
            //--------------------------------------------------------
        }

        public void EnvioForm()
        {
            if(PbCartaA.Enabled == true)
            {

            }

            if (PbCartaB.Enabled == true)
            {

            }

            if (PbCartaC.Enabled == true)
            {

            }

            if (PbCartaD.Enabled == true)
            {

            }
        }

        //------------DELEGADO ???-------------------
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            //----Se recibe el mensaje a través de DELEGADOS ???--------------
            AccesoInterrupcion(SpPuertos.ReadExisting());

            /*string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtDatosRecibidos.Text = Data_in;*/
        }

        private void DatoRecibidoOpcional(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(puertoOpcional.ReadExisting());
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
            if (CboPuertos.Items.Count > 0)
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
                if (BtnConectar.Text == "CON")
                {
                    SpPuertos.BaudRate = Int32.Parse(CboBaudRate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = CboPuertos.Text;

                    puertoOpcional.BaudRate = Int32.Parse(CboBaudRate.Text);
                    puertoOpcional.DataBits = 8;
                    puertoOpcional.Parity = Parity.None;
                    puertoOpcional.StopBits = StopBits.One;
                    puertoOpcional.Handshake = Handshake.None;
                    if(CboPuertos.Text == "COM2")
                    {
                        puertoOpcional.PortName = "COM1";
                    }
                    else if (CboPuertos.Text == "COM3")
                    {
                        puertoOpcional.PortName = "COM2";
                    }
                    else if (CboPuertos.Text == "COM4")
                    {
                        puertoOpcional.PortName = "COM3";
                    }
                    // gameForm.SpPuertosGame = SpPuertos;
                    //TxtPuerto.Text = CboPuertos.Text;
                    //TxtBaudRate.Text = CboBaudRate.Text;

                    try
                    {
                        SpPuertos.Open();
                        puertoOpcional.Open();
                       // gameForm.SpPuertosGame.Open();

                        BtnConectar.Text = "DES";
                        BtnEnviarDatos.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                //'DESCONECTAR' cierra el puerto, cambia a 'CONECTAR' y desabilita el botón 'Enviar Datos'
                else if (BtnConectar.Text == "DES")
                {
                    SpPuertos.Close();
                    BtnConectar.Text = "CON";
                    BtnEnviarDatos.Enabled = false;
                }

                BtnNext.Enabled = true;
            }
            catch (Exception ex)
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

        private void BtnNext_Click(object sender, EventArgs e)
        {

            //SE OCULTA LA CONFIGURACIÓN Y SE MUESTRA EL JUEGO


            //SE OCULTA TODO
            //LblTitulo.Visible = false;
            LblBaudRate.Visible = false;
            LblDatosRecibidos.Visible = false;
            BtnBuscarPuertos.Visible = false;
            BtnConectar.Visible = false;
            BtnEnviarDatos.Visible = false;
            BtnNext.Visible = false;
            CboPuertos.Visible = false;
            CboBaudRate.Visible = false;
            TxtDatosEnviados.Visible = false;
            TxtDatosRecibidos.Visible = false;


            //
            computadora = CboPlayer.Text;
            LblPlayer.Text = computadora;
            //

            //SE MUESTRA TODO
            /*gameForm.Show();
            gameForm.LblPlayer.Text = computadora;*/
            //this.Close();
        }

        private void LblSelectPlayer_Click(object sender, EventArgs e)
        {

        }


        ////////////////////////////////////////////////////////////

        private void BtnHabilitarLabel_Click(object sender, EventArgs e)
        {
            if (BtnHabilitarLabel.Text == "ON")
            {
                /* TxtLastData.Visible = true;
                 TxtPuerto.Visible = true;
                 TxtBaudRate.Visible = true;*/

                LblBaudRate.Visible = false;
                LblDatosRecibidos.Visible = false;
                BtnBuscarPuertos.Visible = false;
                BtnConectar.Visible = false;
                BtnEnviarDatos.Visible = false;
                BtnNext.Visible = false;
                CboPuertos.Visible = false;
                CboBaudRate.Visible = false;
                TxtDatosEnviados.Visible = false;
                TxtDatosRecibidos.Visible = false;
                BtnHabilitarLabel.Text = "OFF";
            }
            else if (BtnHabilitarLabel.Text == "OFF")
            {
                /*TxtLastData.Visible = false;
                TxtPuerto.Visible = false;
                TxtBaudRate.Visible = false;*/

                LblBaudRate.Visible = true;
                LblDatosRecibidos.Visible = true;
                BtnBuscarPuertos.Visible = true;
                BtnConectar.Visible = true;
                BtnEnviarDatos.Visible = true;
                BtnNext.Visible = true;
                CboPuertos.Visible = true;
                CboBaudRate.Visible = true;
                TxtDatosEnviados.Visible = true;
                TxtDatosRecibidos.Visible = true;
                BtnHabilitarLabel.Text = "ON";

            }
        }

        private void PbCarta1_Click(object sender, EventArgs e)
        {
            if (LblPlayer.Text != "")
            {
                if (LblPlayer.Text == "A")
                {
                    PbCartaA.Image = PbCarta1.Image;
                    PbCarta1.Visible = false;
                }

                if (LblPlayer.Text == "B")
                {
                    PbCartaB.Image = PbCarta1.Image;
                    PbCarta1.Visible = false;
                }

                if (LblPlayer.Text == "C")
                {
                    PbCartaC.Image = PbCarta1.Image;
                    PbCarta1.Visible = false;
                }

                if (LblPlayer.Text == "D")
                {
                    PbCartaD.Image = PbCarta1.Image;
                    PbCarta1.Visible = false;
                }

                EnviarDatos("L" + LblPlayer.Text + "S" + "C"+ PbCarta1.Tag);
            }
        }

        private void PbCarta2_Click_1(object sender, EventArgs e)
        {
            if (LblPlayer.Text != "")
            {
                if (LblPlayer.Text == "A")
                {
                    PbCartaA.Image = PbCarta2.Image;
                    PbCarta2.Visible = false;
                }

                if (LblPlayer.Text == "B")
                {
                    PbCartaB.Image = PbCarta2.Image;
                    PbCarta2.Visible = false;
                }

                if (LblPlayer.Text == "C")
                {
                    PbCartaC.Image = PbCarta2.Image;
                    PbCarta2.Visible = false;
                }

                if (LblPlayer.Text == "D")
                {
                    PbCartaD.Image = PbCarta2.Image;
                    PbCarta2.Visible = false;
                }

                EnviarDatos("L" + LblPlayer.Text + "S" + "C" + PbCarta2.Tag);
            }
        }

        private void PbCarta3_Click_1(object sender, EventArgs e)
        {
            if (LblPlayer.Text != "")
            {
                if (LblPlayer.Text == "A")
                {
                    PbCartaA.Image = PbCarta3.Image;
                    PbCarta3.Visible = false;
                }

                if (LblPlayer.Text == "B")
                {
                    PbCartaB.Image = PbCarta3.Image;
                    PbCarta3.Visible = false;
                }

                if (LblPlayer.Text == "C")
                {
                    PbCartaC.Image = PbCarta3.Image;
                    PbCarta3.Visible = false;
                }

                if (LblPlayer.Text == "D")
                {
                    PbCartaD.Image = PbCarta3.Image;
                    PbCarta3.Visible = false;
                }
                EnviarDatos("L" + LblPlayer.Text + "S" + "C" + PbCarta3.Tag);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
