using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrucoClient
{
    public partial class TrucoFormGame : Form
    {
        public TrucoFormGame()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\green-background.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void TrucoFormGame_Load(object sender, EventArgs e)
        {
            PbCarta1.Image = Image.FromFile("E1.png");
            PbCarta2.Image = Image.FromFile("B7.png");
            PbCarta3.Image = Image.FromFile("O7.png");

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


        public void repartir()
        {

        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            //---------AQUÍ SE MANEJA EL MENSAJE RECIBIDO-------------
            TxtLastData.Text = strBufferIn;
            //--------SIMULACIÓN DE PEDIR ENVIDO---------------
            if (strBufferIn[7] == 'S')
            {
                EnviarDatos("$$STSG#S######%%");
            }
            //--------------------------------------------------------
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

        //------------DELEGADO ???-------------------
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }

        private void DatoRecibido(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //----Se recibe el mensaje a través de DELEGADOS ???--------------
            AccesoInterrupcion(SpPuertos.ReadExisting());

            /*string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtDatosRecibidos.Text = Data_in;*/
        }
    }
}
