namespace TrucoClient
{
    partial class TrucoGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PbCarta1 = new System.Windows.Forms.PictureBox();
            this.PbCarta2 = new System.Windows.Forms.PictureBox();
            this.PbCarta3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PbCartaA = new System.Windows.Forms.PictureBox();
            this.PbCartaD = new System.Windows.Forms.PictureBox();
            this.PbCartaB = new System.Windows.Forms.PictureBox();
            this.PbCartaC = new System.Windows.Forms.PictureBox();
            this.BtnHabilitarLabel = new System.Windows.Forms.Button();
            this.TxtLastData = new System.Windows.Forms.TextBox();
            this.PbTurnoB = new System.Windows.Forms.PictureBox();
            this.PbTurnoC = new System.Windows.Forms.PictureBox();
            this.PbTurnoD = new System.Windows.Forms.PictureBox();
            this.PbTurnoA = new System.Windows.Forms.PictureBox();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.LblTitlePlayer = new System.Windows.Forms.Label();
            this.LblPtsAC = new System.Windows.Forms.Label();
            this.LblPtsBD = new System.Windows.Forms.Label();
            this.LblVira = new System.Windows.Forms.Label();
            this.PbVira = new System.Windows.Forms.PictureBox();
            this.BtnTruco = new System.Windows.Forms.Button();
            this.BtnEnvido = new System.Windows.Forms.Button();
            this.TxtPuerto = new System.Windows.Forms.TextBox();
            this.TxtBaudRate = new System.Windows.Forms.TextBox();
            this.puerto = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVira)).BeginInit();
            this.SuspendLayout();
            // 
            // PbCarta1
            // 
            this.PbCarta1.BackColor = System.Drawing.Color.Transparent;
            this.PbCarta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbCarta1.Enabled = false;
            this.PbCarta1.Location = new System.Drawing.Point(248, 302);
            this.PbCarta1.Name = "PbCarta1";
            this.PbCarta1.Size = new System.Drawing.Size(66, 96);
            this.PbCarta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta1.TabIndex = 0;
            this.PbCarta1.TabStop = false;
            this.PbCarta1.Click += new System.EventHandler(this.PbCarta1_Click_1);
            // 
            // PbCarta2
            // 
            this.PbCarta2.BackColor = System.Drawing.Color.Transparent;
            this.PbCarta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbCarta2.Enabled = false;
            this.PbCarta2.Location = new System.Drawing.Point(367, 302);
            this.PbCarta2.Name = "PbCarta2";
            this.PbCarta2.Size = new System.Drawing.Size(66, 96);
            this.PbCarta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta2.TabIndex = 1;
            this.PbCarta2.TabStop = false;
            this.PbCarta2.Click += new System.EventHandler(this.PbCarta2_Click);
            // 
            // PbCarta3
            // 
            this.PbCarta3.BackColor = System.Drawing.Color.Transparent;
            this.PbCarta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbCarta3.Enabled = false;
            this.PbCarta3.Location = new System.Drawing.Point(481, 302);
            this.PbCarta3.Name = "PbCarta3";
            this.PbCarta3.Size = new System.Drawing.Size(66, 96);
            this.PbCarta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta3.TabIndex = 2;
            this.PbCarta3.TabStop = false;
            this.PbCarta3.Click += new System.EventHandler(this.PbCarta3_Click);
            // 
            // PbCartaA
            // 
            this.PbCartaA.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaA.Location = new System.Drawing.Point(367, 186);
            this.PbCartaA.Name = "PbCartaA";
            this.PbCartaA.Size = new System.Drawing.Size(66, 96);
            this.PbCartaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaA.TabIndex = 3;
            this.PbCartaA.TabStop = false;
            // 
            // PbCartaD
            // 
            this.PbCartaD.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaD.Location = new System.Drawing.Point(176, 120);
            this.PbCartaD.Name = "PbCartaD";
            this.PbCartaD.Size = new System.Drawing.Size(66, 96);
            this.PbCartaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaD.TabIndex = 4;
            this.PbCartaD.TabStop = false;
            // 
            // PbCartaB
            // 
            this.PbCartaB.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaB.Location = new System.Drawing.Point(546, 120);
            this.PbCartaB.Name = "PbCartaB";
            this.PbCartaB.Size = new System.Drawing.Size(66, 96);
            this.PbCartaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaB.TabIndex = 5;
            this.PbCartaB.TabStop = false;
            // 
            // PbCartaC
            // 
            this.PbCartaC.BackColor = System.Drawing.Color.Transparent;
            this.PbCartaC.Location = new System.Drawing.Point(367, 21);
            this.PbCartaC.Name = "PbCartaC";
            this.PbCartaC.Size = new System.Drawing.Size(66, 96);
            this.PbCartaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaC.TabIndex = 6;
            this.PbCartaC.TabStop = false;
            // 
            // BtnHabilitarLabel
            // 
            this.BtnHabilitarLabel.Location = new System.Drawing.Point(723, 279);
            this.BtnHabilitarLabel.Name = "BtnHabilitarLabel";
            this.BtnHabilitarLabel.Size = new System.Drawing.Size(42, 23);
            this.BtnHabilitarLabel.TabIndex = 7;
            this.BtnHabilitarLabel.Text = "ON";
            this.BtnHabilitarLabel.UseVisualStyleBackColor = true;
            this.BtnHabilitarLabel.Click += new System.EventHandler(this.BtnHabilitarLabel_Click);
            // 
            // TxtLastData
            // 
            this.TxtLastData.Enabled = false;
            this.TxtLastData.Location = new System.Drawing.Point(652, 316);
            this.TxtLastData.Name = "TxtLastData";
            this.TxtLastData.Size = new System.Drawing.Size(134, 20);
            this.TxtLastData.TabIndex = 8;
            this.TxtLastData.Visible = false;
            // 
            // PbTurnoB
            // 
            this.PbTurnoB.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoB.Location = new System.Drawing.Point(618, 149);
            this.PbTurnoB.Name = "PbTurnoB";
            this.PbTurnoB.Size = new System.Drawing.Size(43, 38);
            this.PbTurnoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoB.TabIndex = 10;
            this.PbTurnoB.TabStop = false;
            this.PbTurnoB.Visible = false;
            // 
            // PbTurnoC
            // 
            this.PbTurnoC.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoC.Location = new System.Drawing.Point(439, 50);
            this.PbTurnoC.Name = "PbTurnoC";
            this.PbTurnoC.Size = new System.Drawing.Size(43, 38);
            this.PbTurnoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoC.TabIndex = 11;
            this.PbTurnoC.TabStop = false;
            this.PbTurnoC.Visible = false;
            // 
            // PbTurnoD
            // 
            this.PbTurnoD.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoD.Location = new System.Drawing.Point(248, 149);
            this.PbTurnoD.Name = "PbTurnoD";
            this.PbTurnoD.Size = new System.Drawing.Size(43, 38);
            this.PbTurnoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoD.TabIndex = 12;
            this.PbTurnoD.TabStop = false;
            this.PbTurnoD.Visible = false;
            // 
            // PbTurnoA
            // 
            this.PbTurnoA.BackColor = System.Drawing.Color.Transparent;
            this.PbTurnoA.Location = new System.Drawing.Point(439, 212);
            this.PbTurnoA.Name = "PbTurnoA";
            this.PbTurnoA.Size = new System.Drawing.Size(43, 40);
            this.PbTurnoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTurnoA.TabIndex = 13;
            this.PbTurnoA.TabStop = false;
            this.PbTurnoA.Visible = false;
            // 
            // LblPlayer
            // 
            this.LblPlayer.AutoSize = true;
            this.LblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.Location = new System.Drawing.Point(66, 186);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(0, 42);
            this.LblPlayer.TabIndex = 14;
            // 
            // LblTitlePlayer
            // 
            this.LblTitlePlayer.AutoSize = true;
            this.LblTitlePlayer.BackColor = System.Drawing.Color.Transparent;
            this.LblTitlePlayer.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlePlayer.ForeColor = System.Drawing.Color.White;
            this.LblTitlePlayer.Location = new System.Drawing.Point(12, 129);
            this.LblTitlePlayer.Name = "LblTitlePlayer";
            this.LblTitlePlayer.Size = new System.Drawing.Size(160, 31);
            this.LblTitlePlayer.TabIndex = 15;
            this.LblTitlePlayer.Text = "JUGADOR";
            // 
            // LblPtsAC
            // 
            this.LblPtsAC.AutoSize = true;
            this.LblPtsAC.BackColor = System.Drawing.Color.Transparent;
            this.LblPtsAC.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPtsAC.ForeColor = System.Drawing.Color.White;
            this.LblPtsAC.Location = new System.Drawing.Point(14, 21);
            this.LblPtsAC.Name = "LblPtsAC";
            this.LblPtsAC.Size = new System.Drawing.Size(162, 21);
            this.LblPtsAC.TabIndex = 16;
            this.LblPtsAC.Text = "Pts. Equipo AC:";
            // 
            // LblPtsBD
            // 
            this.LblPtsBD.AutoSize = true;
            this.LblPtsBD.BackColor = System.Drawing.Color.Transparent;
            this.LblPtsBD.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPtsBD.ForeColor = System.Drawing.Color.White;
            this.LblPtsBD.Location = new System.Drawing.Point(15, 64);
            this.LblPtsBD.Name = "LblPtsBD";
            this.LblPtsBD.Size = new System.Drawing.Size(161, 21);
            this.LblPtsBD.TabIndex = 17;
            this.LblPtsBD.Text = "Pts. Equipo BD:";
            // 
            // LblVira
            // 
            this.LblVira.AutoSize = true;
            this.LblVira.BackColor = System.Drawing.Color.Transparent;
            this.LblVira.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVira.ForeColor = System.Drawing.Color.White;
            this.LblVira.Location = new System.Drawing.Point(702, 21);
            this.LblVira.Name = "LblVira";
            this.LblVira.Size = new System.Drawing.Size(64, 21);
            this.LblVira.TabIndex = 18;
            this.LblVira.Text = "VIRA";
            // 
            // PbVira
            // 
            this.PbVira.BackColor = System.Drawing.Color.Transparent;
            this.PbVira.Location = new System.Drawing.Point(699, 50);
            this.PbVira.Name = "PbVira";
            this.PbVira.Size = new System.Drawing.Size(66, 96);
            this.PbVira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVira.TabIndex = 19;
            this.PbVira.TabStop = false;
            // 
            // BtnTruco
            // 
            this.BtnTruco.BackColor = System.Drawing.Color.Snow;
            this.BtnTruco.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTruco.Location = new System.Drawing.Point(19, 302);
            this.BtnTruco.Name = "BtnTruco";
            this.BtnTruco.Size = new System.Drawing.Size(192, 43);
            this.BtnTruco.TabIndex = 20;
            this.BtnTruco.Text = "TRUCO";
            this.BtnTruco.UseVisualStyleBackColor = false;
            // 
            // BtnEnvido
            // 
            this.BtnEnvido.BackColor = System.Drawing.Color.Snow;
            this.BtnEnvido.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnvido.Location = new System.Drawing.Point(19, 355);
            this.BtnEnvido.Name = "BtnEnvido";
            this.BtnEnvido.Size = new System.Drawing.Size(192, 43);
            this.BtnEnvido.TabIndex = 21;
            this.BtnEnvido.Text = "ENVIDO";
            this.BtnEnvido.UseVisualStyleBackColor = false;
            // 
            // TxtPuerto
            // 
            this.TxtPuerto.Enabled = false;
            this.TxtPuerto.Location = new System.Drawing.Point(652, 355);
            this.TxtPuerto.Name = "TxtPuerto";
            this.TxtPuerto.Size = new System.Drawing.Size(71, 20);
            this.TxtPuerto.TabIndex = 22;
            this.TxtPuerto.Visible = false;
            // 
            // TxtBaudRate
            // 
            this.TxtBaudRate.Enabled = false;
            this.TxtBaudRate.Location = new System.Drawing.Point(652, 390);
            this.TxtBaudRate.Name = "TxtBaudRate";
            this.TxtBaudRate.Size = new System.Drawing.Size(71, 20);
            this.TxtBaudRate.TabIndex = 23;
            this.TxtBaudRate.Visible = false;
            // 
            // TrucoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 431);
            this.Controls.Add(this.TxtBaudRate);
            this.Controls.Add(this.TxtPuerto);
            this.Controls.Add(this.BtnEnvido);
            this.Controls.Add(this.BtnTruco);
            this.Controls.Add(this.PbVira);
            this.Controls.Add(this.LblVira);
            this.Controls.Add(this.LblPtsBD);
            this.Controls.Add(this.LblPtsAC);
            this.Controls.Add(this.LblTitlePlayer);
            this.Controls.Add(this.LblPlayer);
            this.Controls.Add(this.PbTurnoA);
            this.Controls.Add(this.PbTurnoD);
            this.Controls.Add(this.PbTurnoC);
            this.Controls.Add(this.PbTurnoB);
            this.Controls.Add(this.TxtLastData);
            this.Controls.Add(this.BtnHabilitarLabel);
            this.Controls.Add(this.PbCartaC);
            this.Controls.Add(this.PbCartaB);
            this.Controls.Add(this.PbCartaD);
            this.Controls.Add(this.PbCartaA);
            this.Controls.Add(this.PbCarta3);
            this.Controls.Add(this.PbCarta2);
            this.Controls.Add(this.PbCarta1);
            this.Name = "TrucoGame";
            this.Text = "TrucoGame";
            this.Load += new System.EventHandler(this.TrucoFormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTurnoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnHabilitarLabel;
        public System.Windows.Forms.TextBox TxtLastData;
        public System.Windows.Forms.PictureBox PbCarta1;
        public System.Windows.Forms.PictureBox PbCarta2;
        public System.Windows.Forms.PictureBox PbCarta3;
        public System.Windows.Forms.PictureBox PbCartaA;
        public System.Windows.Forms.PictureBox PbCartaD;
        public System.Windows.Forms.PictureBox PbCartaB;
        public System.Windows.Forms.PictureBox PbCartaC;
        public System.Windows.Forms.PictureBox PbTurnoB;
        public System.Windows.Forms.PictureBox PbTurnoC;
        public System.Windows.Forms.PictureBox PbTurnoD;
        public System.Windows.Forms.PictureBox PbTurnoA;
        public System.Windows.Forms.Label LblPlayer;
        public System.Windows.Forms.Label LblTitlePlayer;
        private System.Windows.Forms.Label LblPtsAC;
        private System.Windows.Forms.Label LblPtsBD;
        private System.Windows.Forms.Label LblVira;
        public System.Windows.Forms.PictureBox PbVira;
        private System.Windows.Forms.Button BtnTruco;
        private System.Windows.Forms.Button BtnEnvido;
        public System.Windows.Forms.TextBox TxtPuerto;
        public System.Windows.Forms.TextBox TxtBaudRate;
        private System.IO.Ports.SerialPort puerto;
    }
}