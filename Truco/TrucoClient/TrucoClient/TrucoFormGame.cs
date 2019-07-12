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

namespace TrucoClient
{
    public partial class TrucoGame : Form
    {
        public TrucoGame()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\green-background.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            TxtLastData.Enabled = false;            
        }

        //TrucoForm configForm = new TrucoForm();

        

        public void TrucoFormGame_Load(object sender, EventArgs e)
        {
          //  SpPuertosGame = configForm.SpPuertos;

           /* PbCarta1.Image = Image.FromFile("E1.png");
            PbCarta2.Image = Image.FromFile("B7.png");
            PbCarta3.Image = Image.FromFile("O7.png");*/

            PbCartaA.Image = Image.FromFile("PLACE.png");
            PbCartaB.Image = Image.FromFile("PLACE.png");
            PbCartaC.Image = Image.FromFile("PLACE.png");
            PbCartaD.Image = Image.FromFile("PLACE.png");


            /*puerto.BaudRate = Int32.Parse(TxtBaudRate.Text);
            puerto.DataBits = 8;
            puerto.Parity = Parity.None;
            puerto.StopBits = StopBits.One;
            puerto.Handshake = Handshake.None;
            puerto.PortName = TxtPuerto.Text;

            try
            {
                puerto.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/

        }

        //------------DELEGADO ???-------------------
        public delegate void DelegadoAcceso(string accion);
        //------------Strings donde se enviarán y recibirán los datos----------
        private string strBufferIn;
        private string strBufferOut;


        private void repartir()
        {

        }

       /* private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            //---------AQUÍ SE MANEJA EL MENSAJE RECIBIDO-------------
            TxtLastData.Text = strBufferIn;
            //--------SIMULACIÓN DE PEDIR ENVIDO---------------
           /* if (strBufferIn[7] == 'S')
            {
                EnviarDatos("$$STSG#S######%%");
            }*/
            //--------------------------------------------------------
        //}

        private void EnviarDatos(string msg)
        {
            //Se llena el buffer de salida y se envían los datos
            try
            {
                //---------AQUÍ SE MANEJA EL MENSAJE ENVIADO-------------
                puerto.DiscardOutBuffer();
                strBufferOut = msg;
                puerto.Write(msg);
                //-------------------------------------------------------
            }
            catch (Exception ex)
            {
                //Si hay algún problema enviando datos se muestra por pantalla el error
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //------------DELEGADO ???-------------------
     /*   private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }*/

        private void DatoRecibidoGame(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //----Se recibe el mensaje a través de DELEGADOS ???--------------
           // AccesoInterrupcion(SpPuertosGame.ReadExisting());

            /*string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtDatosRecibidos.Text = Data_in;*/
        }

        private void BtnHabilitarLabel_Click(object sender, EventArgs e)
        {
            if (BtnHabilitarLabel.Text == "ON")
            {
                TxtLastData.Visible = true;
                TxtPuerto.Visible = true;
                TxtBaudRate.Visible = true;
                BtnHabilitarLabel.Text = "OFF";
            }
            else if(BtnHabilitarLabel.Text == "OFF")
            {
                TxtLastData.Visible = false;
                TxtPuerto.Visible = false;
                TxtBaudRate.Visible = false;
                BtnHabilitarLabel.Text = "ON";

            }
        }

        private void PbCarta1_Click_1(object sender, EventArgs e)
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

                EnviarDatos("LC" + LblPlayer.Text + "S" + PbCarta1.Tag);
            }
        }

        private void PbCarta2_Click(object sender, EventArgs e)
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

                EnviarDatos("LC" + LblPlayer.Text + "S" + PbCarta2.Tag);
            }
        }

        private void PbCarta3_Click(object sender, EventArgs e)
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
                EnviarDatos("LC" + LblPlayer.Text + "S" + PbCarta3.Tag);
            }
        }
    }
}
