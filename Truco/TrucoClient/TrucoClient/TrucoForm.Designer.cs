namespace TrucoClient
{
    partial class TrucoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnBuscarPuertos = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.LblDatosRecibidos = new System.Windows.Forms.Label();
            this.TxtDatosEnviados = new System.Windows.Forms.TextBox();
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.BtnNext = new System.Windows.Forms.Button();
            this.CboPlayer = new System.Windows.Forms.ComboBox();
            this.LblSelectPlayer = new System.Windows.Forms.Label();
            this.PbVira = new System.Windows.Forms.PictureBox();
            this.LblVira = new System.Windows.Forms.Label();
            this.LblPtsBD = new System.Windows.Forms.Label();
            this.LblPtsAC = new System.Windows.Forms.Label();
            this.LblTitlePlayer = new System.Windows.Forms.Label();
            this.PbTurnoA = new System.Windows.Forms.PictureBox();
            this.PbTurnoD = new System.Windows.Forms.PictureBox();
            this.PbTurnoC = new System.Windows.Forms.PictureBox();
            this.PbTurnoB = new System.Windows.Forms.PictureBox();
            this.BtnHabilitarLabel = new System.Windows.Forms.Button();
            this.PbCartaC = new System.Windows.Forms.PictureBox();
            this.PbCartaB = new System.Windows.Forms.PictureBox();
            this.PbCartaD = new System.Windows.Forms.PictureBox();
            this.PbCartaA = new System.Windows.Forms.PictureBox();
            this.BtnEnvido = new System.Windows.Forms.Button();
            this.BtnTruco = new System.Windows.Forms.Button();
            this.PbCarta3 = new System.Windows.Forms.PictureBox();
            this.PbCarta2 = new System.Windows.Forms.PictureBox();
            this.PbCarta1 = new System.Windows.Forms.PictureBox();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.LblPuntosAC = new System.Windows.Forms.Label();
            this.LblPuntosBD = new System.Windows.Forms.Label();
            this.LblPuntosEnvido = new System.Windows.Forms.Label();
            this.LblPuntosApuesta = new System.Windows.Forms.Label();
            this.LblEnvido = new System.Windows.Forms.Label();
            this.LblApuesta = new System.Windows.Forms.Label();
            this.puertoOpcional = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbVira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscarPuertos
            // 
            this.BtnBuscarPuertos.Location = new System.Drawing.Point(588, 328);
            this.BtnBuscarPuertos.Name = "BtnBuscarPuertos";
            this.BtnBuscarPuertos.Size = new System.Drawing.Size(89, 23);
            this.BtnBuscarPuertos.TabIndex = 0;
            this.BtnBuscarPuertos.Text = "Buscar puertos";
            this.BtnBuscarPuertos.UseVisualStyleBackColor = true;
            this.BtnBuscarPuertos.Click += new System.EventHandler(this.BtnBuscarPuertos_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.Location = new System.Drawing.Point(651, 382);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviarDatos.TabIndex = 1;
            this.BtnEnviarDatos.Text = "Enviar datos";
            this.BtnEnviarDatos.UseVisualStyleBackColor = true;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(753, 328);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(41, 23);
            this.BtnConectar.TabIndex = 2;
            this.BtnConectar.Text = "CON";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(683, 330);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(64, 21);
            this.CboPuertos.TabIndex = 3;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(651, 357);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(54, 21);
            this.CboBaudRate.TabIndex = 4;
            this.CboBaudRate.Text = "9600";
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.Location = new System.Drawing.Point(623, 360);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(22, 13);
            this.LblBaudRate.TabIndex = 5;
            this.LblBaudRate.Text = "BR";
            // 
            // LblDatosRecibidos
            // 
            this.LblDatosRecibidos.AutoSize = true;
            this.LblDatosRecibidos.Location = new System.Drawing.Point(447, 413);
            this.LblDatosRecibidos.Name = "LblDatosRecibidos";
            this.LblDatosRecibidos.Size = new System.Drawing.Size(80, 13);
            this.LblDatosRecibidos.TabIndex = 6;
            this.LblDatosRecibidos.Text = "Datos recibidos";
            // 
            // TxtDatosEnviados
            // 
            this.TxtDatosEnviados.Location = new System.Drawing.Point(734, 384);
            this.TxtDatosEnviados.Name = "TxtDatosEnviados";
            this.TxtDatosEnviados.Size = new System.Drawing.Size(54, 20);
            this.TxtDatosEnviados.TabIndex = 7;
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(524, 410);
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(264, 20);
            this.TxtDatosRecibidos.TabIndex = 8;
            // 
            // SpPuertos
            // 
            this.SpPuertos.PortName = "COM20";
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(742, 273);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(52, 49);
            this.BtnNext.TabIndex = 9;
            this.BtnNext.Text = "Ir al juego";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // CboPlayer
            // 
            this.CboPlayer.FormattingEnabled = true;
            this.CboPlayer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CboPlayer.Location = new System.Drawing.Point(745, 357);
            this.CboPlayer.Name = "CboPlayer";
            this.CboPlayer.Size = new System.Drawing.Size(43, 21);
            this.CboPlayer.TabIndex = 11;
            // 
            // LblSelectPlayer
            // 
            this.LblSelectPlayer.AutoSize = true;
            this.LblSelectPlayer.Location = new System.Drawing.Point(709, 360);
            this.LblSelectPlayer.Name = "LblSelectPlayer";
            this.LblSelectPlayer.Size = new System.Drawing.Size(30, 13);
            this.LblSelectPlayer.TabIndex = 12;
            this.LblSelectPlayer.Text = "Sel J";
            this.LblSelectPlayer.Click += new System.EventHandler(this.LblSelectPlayer_Click);
            // 
            // PbVira
            // 
            this.PbVira.BackColor = System.Drawing.Color.Transparent;
            this.PbVira.Location = new System.Drawing.Point(710, 53);
            this.PbVira.Name = "PbVira";
            this.PbVira.Size = new System.Drawing.Size(66, 96);
            this.PbVira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVira.TabIndex = 33;
            this.PbVira.TabStop = false;
            // 
            // LblVira
            // 
            this.LblVira.AutoSize = true;
            this.LblVira.BackColor = System.Drawing.Color.Transparent;
            this.LblVira.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVira.ForeColor = System.Drawing.Color.White;
            this.LblVira.Location = new System.Drawing.Point(713, 24);
            this.LblVira.Name = "LblVira";
            this.LblVira.Size = new System.Drawing.Size(64, 21);
            this.LblVira.TabIndex = 32;
            this.LblVira.Text = "VIRA";
            // 
            // LblPtsBD
            // 
            this.LblPtsBD.AutoSize = true;
            this.LblPtsBD.BackColor = System.Drawing.Color.Transparent;
            this.LblPtsBD.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPtsBD.ForeColor = System.Drawing.Color.White;
            this.LblPtsBD.Location = new System.Drawing.Point(26, 67);
            this.LblPtsBD.Name = "LblPtsBD";
            this.LblPtsBD.Size = new System.Drawing.Size(161, 21);
            this.LblPtsBD.TabIndex = 31;
            this.LblPtsBD.Text = "Pts. Equipo BD:";
            // 
            // LblPtsAC
            // 
            this.LblPtsAC.AutoSize = true;
            this.LblPtsAC.BackColor = System.Drawing.Color.Transparent;
            this.LblPtsAC.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPtsAC.ForeColor = System.Drawing.Color.White;
            this.LblPtsAC.Location = new System.Drawing.Point(25, 24);
            this.LblPtsAC.Name = "LblPtsAC";
            this.LblPtsAC.Size = new System.Drawing.Size(162, 21);
            this.LblPtsAC.TabIndex = 30;
            this.LblPtsAC.Text = "Pts. Equipo AC:";
            // 
            // LblTitlePlayer
            // 
            this.LblTitlePlayer.AutoSize = true;
            this.LblTitlePlayer.BackColor = System.Drawing.Color.Transparent;
            this.LblTitlePlayer.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlePlayer.ForeColor = System.Drawing.Color.White;
            this.LblTitlePlayer.Location = new System.Drawing.Point(23, 132);
            this.LblTitlePlayer.Name = "LblTitlePlayer";
            this.LblTitlePlayer.Size = new System.Drawing.Size(160, 31);
            this.LblTitlePlayer.TabIndex = 29;
            this.LblTitlePlayer.Text = "JUGADOR";
            // 
            // PbTurnoA
            // 
            this.PbTurnoA.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoA.Location = new System.Drawing.Point(450, 215);
            this.PbTurnoA.Name = "PbTurnoA";
            this.PbTurnoA.Size = new System.Drawing.Size(43, 40);
            this.PbTurnoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoA.TabIndex = 28;
            this.PbTurnoA.TabStop = false;
            this.PbTurnoA.Visible = false;
            // 
            // PbTurnoD
            // 
            this.PbTurnoD.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoD.Location = new System.Drawing.Point(259, 152);
            this.PbTurnoD.Name = "PbTurnoD";
            this.PbTurnoD.Size = new System.Drawing.Size(43, 38);
            this.PbTurnoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoD.TabIndex = 27;
            this.PbTurnoD.TabStop = false;
            this.PbTurnoD.Visible = false;
            // 
            // PbTurnoC
            // 
            this.PbTurnoC.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoC.Location = new System.Drawing.Point(450, 53);
            this.PbTurnoC.Name = "PbTurnoC";
            this.PbTurnoC.Size = new System.Drawing.Size(43, 38);
            this.PbTurnoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoC.TabIndex = 26;
            this.PbTurnoC.TabStop = false;
            this.PbTurnoC.Visible = false;
            // 
            // PbTurnoB
            // 
            this.PbTurnoB.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoB.Location = new System.Drawing.Point(629, 152);
            this.PbTurnoB.Name = "PbTurnoB";
            this.PbTurnoB.Size = new System.Drawing.Size(43, 38);
            this.PbTurnoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoB.TabIndex = 25;
            this.PbTurnoB.TabStop = false;
            this.PbTurnoB.Visible = false;
            // 
            // BtnHabilitarLabel
            // 
            this.BtnHabilitarLabel.Location = new System.Drawing.Point(683, 286);
            this.BtnHabilitarLabel.Name = "BtnHabilitarLabel";
            this.BtnHabilitarLabel.Size = new System.Drawing.Size(42, 23);
            this.BtnHabilitarLabel.TabIndex = 24;
            this.BtnHabilitarLabel.Text = "ON";
            this.BtnHabilitarLabel.UseVisualStyleBackColor = true;
            this.BtnHabilitarLabel.Click += new System.EventHandler(this.BtnHabilitarLabel_Click);
            // 
            // PbCartaC
            // 
            this.PbCartaC.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaC.Location = new System.Drawing.Point(378, 24);
            this.PbCartaC.Name = "PbCartaC";
            this.PbCartaC.Size = new System.Drawing.Size(66, 96);
            this.PbCartaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaC.TabIndex = 23;
            this.PbCartaC.TabStop = false;
            // 
            // PbCartaB
            // 
            this.PbCartaB.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaB.Location = new System.Drawing.Point(557, 123);
            this.PbCartaB.Name = "PbCartaB";
            this.PbCartaB.Size = new System.Drawing.Size(66, 96);
            this.PbCartaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaB.TabIndex = 22;
            this.PbCartaB.TabStop = false;
            // 
            // PbCartaD
            // 
            this.PbCartaD.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaD.Location = new System.Drawing.Point(187, 123);
            this.PbCartaD.Name = "PbCartaD";
            this.PbCartaD.Size = new System.Drawing.Size(66, 96);
            this.PbCartaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaD.TabIndex = 21;
            this.PbCartaD.TabStop = false;
            // 
            // PbCartaA
            // 
            this.PbCartaA.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaA.Location = new System.Drawing.Point(378, 189);
            this.PbCartaA.Name = "PbCartaA";
            this.PbCartaA.Size = new System.Drawing.Size(66, 96);
            this.PbCartaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaA.TabIndex = 20;
            this.PbCartaA.TabStop = false;
            // 
            // BtnEnvido
            // 
            this.BtnEnvido.BackColor = System.Drawing.Color.Snow;
            this.BtnEnvido.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnvido.Location = new System.Drawing.Point(30, 362);
            this.BtnEnvido.Name = "BtnEnvido";
            this.BtnEnvido.Size = new System.Drawing.Size(192, 43);
            this.BtnEnvido.TabIndex = 38;
            this.BtnEnvido.Text = "ENVIDO";
            this.BtnEnvido.UseVisualStyleBackColor = false;
            // 
            // BtnTruco
            // 
            this.BtnTruco.BackColor = System.Drawing.Color.Snow;
            this.BtnTruco.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTruco.Location = new System.Drawing.Point(30, 309);
            this.BtnTruco.Name = "BtnTruco";
            this.BtnTruco.Size = new System.Drawing.Size(192, 43);
            this.BtnTruco.TabIndex = 37;
            this.BtnTruco.Text = "TRUCO";
            this.BtnTruco.UseVisualStyleBackColor = false;
            // 
            // PbCarta3
            // 
            this.PbCarta3.BackColor = System.Drawing.Color.Transparent;
            this.PbCarta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbCarta3.Enabled = false;
            this.PbCarta3.Location = new System.Drawing.Point(492, 309);
            this.PbCarta3.Name = "PbCarta3";
            this.PbCarta3.Size = new System.Drawing.Size(66, 96);
            this.PbCarta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta3.TabIndex = 36;
            this.PbCarta3.TabStop = false;
            this.PbCarta3.Click += new System.EventHandler(this.PbCarta3_Click_1);
            // 
            // PbCarta2
            // 
            this.PbCarta2.BackColor = System.Drawing.Color.Transparent;
            this.PbCarta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbCarta2.Enabled = false;
            this.PbCarta2.Location = new System.Drawing.Point(378, 309);
            this.PbCarta2.Name = "PbCarta2";
            this.PbCarta2.Size = new System.Drawing.Size(66, 96);
            this.PbCarta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta2.TabIndex = 35;
            this.PbCarta2.TabStop = false;
            this.PbCarta2.Click += new System.EventHandler(this.PbCarta2_Click_1);
            // 
            // PbCarta1
            // 
            this.PbCarta1.BackColor = System.Drawing.Color.Transparent;
            this.PbCarta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbCarta1.Enabled = false;
            this.PbCarta1.Location = new System.Drawing.Point(259, 309);
            this.PbCarta1.Name = "PbCarta1";
            this.PbCarta1.Size = new System.Drawing.Size(66, 96);
            this.PbCarta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta1.TabIndex = 34;
            this.PbCarta1.TabStop = false;
            this.PbCarta1.Click += new System.EventHandler(this.PbCarta1_Click);
            // 
            // LblPlayer
            // 
            this.LblPlayer.AutoSize = true;
            this.LblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.Location = new System.Drawing.Point(84, 189);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(0, 42);
            this.LblPlayer.TabIndex = 39;
            // 
            // LblPuntosAC
            // 
            this.LblPuntosAC.AutoSize = true;
            this.LblPuntosAC.BackColor = System.Drawing.Color.Transparent;
            this.LblPuntosAC.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntosAC.ForeColor = System.Drawing.Color.Black;
            this.LblPuntosAC.Location = new System.Drawing.Point(193, 24);
            this.LblPuntosAC.Name = "LblPuntosAC";
            this.LblPuntosAC.Size = new System.Drawing.Size(0, 21);
            this.LblPuntosAC.TabIndex = 40;
            // 
            // LblPuntosBD
            // 
            this.LblPuntosBD.AutoSize = true;
            this.LblPuntosBD.BackColor = System.Drawing.Color.Transparent;
            this.LblPuntosBD.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntosBD.ForeColor = System.Drawing.Color.Black;
            this.LblPuntosBD.Location = new System.Drawing.Point(193, 67);
            this.LblPuntosBD.Name = "LblPuntosBD";
            this.LblPuntosBD.Size = new System.Drawing.Size(0, 21);
            this.LblPuntosBD.TabIndex = 41;
            // 
            // LblPuntosEnvido
            // 
            this.LblPuntosEnvido.AutoSize = true;
            this.LblPuntosEnvido.BackColor = System.Drawing.Color.Transparent;
            this.LblPuntosEnvido.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntosEnvido.ForeColor = System.Drawing.Color.Black;
            this.LblPuntosEnvido.Location = new System.Drawing.Point(605, 79);
            this.LblPuntosEnvido.Name = "LblPuntosEnvido";
            this.LblPuntosEnvido.Size = new System.Drawing.Size(0, 21);
            this.LblPuntosEnvido.TabIndex = 45;
            this.LblPuntosEnvido.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPuntosApuesta
            // 
            this.LblPuntosApuesta.AutoSize = true;
            this.LblPuntosApuesta.BackColor = System.Drawing.Color.Transparent;
            this.LblPuntosApuesta.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntosApuesta.ForeColor = System.Drawing.Color.Black;
            this.LblPuntosApuesta.Location = new System.Drawing.Point(618, 36);
            this.LblPuntosApuesta.Name = "LblPuntosApuesta";
            this.LblPuntosApuesta.Size = new System.Drawing.Size(0, 21);
            this.LblPuntosApuesta.TabIndex = 44;
            this.LblPuntosApuesta.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblEnvido
            // 
            this.LblEnvido.AutoSize = true;
            this.LblEnvido.BackColor = System.Drawing.Color.Transparent;
            this.LblEnvido.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnvido.ForeColor = System.Drawing.Color.White;
            this.LblEnvido.Location = new System.Drawing.Point(511, 79);
            this.LblEnvido.Name = "LblEnvido";
            this.LblEnvido.Size = new System.Drawing.Size(84, 21);
            this.LblEnvido.TabIndex = 43;
            this.LblEnvido.Text = "Envido:";
            this.LblEnvido.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblApuesta
            // 
            this.LblApuesta.AutoSize = true;
            this.LblApuesta.BackColor = System.Drawing.Color.Transparent;
            this.LblApuesta.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApuesta.ForeColor = System.Drawing.Color.White;
            this.LblApuesta.Location = new System.Drawing.Point(510, 36);
            this.LblApuesta.Name = "LblApuesta";
            this.LblApuesta.Size = new System.Drawing.Size(97, 21);
            this.LblApuesta.TabIndex = 42;
            this.LblApuesta.Text = "Apuesta:";
            this.LblApuesta.Click += new System.EventHandler(this.label4_Click);
            // 
            // puertoOpcional
            // 
            this.puertoOpcional.PortName = "COM30";
            this.puertoOpcional.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibidoOpcional);
            // 
            // TrucoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblPuntosEnvido);
            this.Controls.Add(this.LblPuntosApuesta);
            this.Controls.Add(this.LblEnvido);
            this.Controls.Add(this.LblApuesta);
            this.Controls.Add(this.LblPuntosBD);
            this.Controls.Add(this.LblPuntosAC);
            this.Controls.Add(this.LblPlayer);
            this.Controls.Add(this.BtnEnvido);
            this.Controls.Add(this.BtnTruco);
            this.Controls.Add(this.PbCarta3);
            this.Controls.Add(this.PbCarta2);
            this.Controls.Add(this.PbCarta1);
            this.Controls.Add(this.PbVira);
            this.Controls.Add(this.LblVira);
            this.Controls.Add(this.LblPtsBD);
            this.Controls.Add(this.LblPtsAC);
            this.Controls.Add(this.LblTitlePlayer);
            this.Controls.Add(this.PbTurnoA);
            this.Controls.Add(this.PbTurnoD);
            this.Controls.Add(this.PbTurnoC);
            this.Controls.Add(this.PbTurnoB);
            this.Controls.Add(this.BtnHabilitarLabel);
            this.Controls.Add(this.PbCartaC);
            this.Controls.Add(this.PbCartaB);
            this.Controls.Add(this.PbCartaD);
            this.Controls.Add(this.PbCartaA);
            this.Controls.Add(this.LblSelectPlayer);
            this.Controls.Add(this.CboPlayer);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Controls.Add(this.TxtDatosEnviados);
            this.Controls.Add(this.LblDatosRecibidos);
            this.Controls.Add(this.LblBaudRate);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnEnviarDatos);
            this.Controls.Add(this.BtnBuscarPuertos);
            this.Name = "TrucoForm";
            this.Text = "Truco";
            this.Load += new System.EventHandler(this.TrucoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbVira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPuertos;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.Label LblDatosRecibidos;
        private System.Windows.Forms.TextBox TxtDatosEnviados;
        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.Windows.Forms.Button BtnNext;
        public System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.ComboBox CboPlayer;
        private System.Windows.Forms.Label LblSelectPlayer;
        public System.Windows.Forms.PictureBox PbVira;
        private System.Windows.Forms.Label LblVira;
        private System.Windows.Forms.Label LblPtsBD;
        private System.Windows.Forms.Label LblPtsAC;
        public System.Windows.Forms.Label LblTitlePlayer;
        public System.Windows.Forms.PictureBox PbTurnoA;
        public System.Windows.Forms.PictureBox PbTurnoD;
        public System.Windows.Forms.PictureBox PbTurnoC;
        public System.Windows.Forms.PictureBox PbTurnoB;
        private System.Windows.Forms.Button BtnHabilitarLabel;
        public System.Windows.Forms.PictureBox PbCartaC;
        public System.Windows.Forms.PictureBox PbCartaB;
        public System.Windows.Forms.PictureBox PbCartaD;
        public System.Windows.Forms.PictureBox PbCartaA;
        private System.Windows.Forms.Button BtnEnvido;
        private System.Windows.Forms.Button BtnTruco;
        public System.Windows.Forms.PictureBox PbCarta3;
        public System.Windows.Forms.PictureBox PbCarta2;
        public System.Windows.Forms.PictureBox PbCarta1;
        public System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.Label LblPuntosAC;
        private System.Windows.Forms.Label LblPuntosBD;
        private System.Windows.Forms.Label LblPuntosEnvido;
        private System.Windows.Forms.Label LblPuntosApuesta;
        private System.Windows.Forms.Label LblEnvido;
        private System.Windows.Forms.Label LblApuesta;
        private System.IO.Ports.SerialPort puertoOpcional;
    }
}

