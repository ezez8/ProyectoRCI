namespace TrucoClient
{
    partial class TrucoFormGame
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
            this.SpPuertosGame = new System.IO.Ports.SerialPort(this.components);
            this.PbTurnoB = new System.Windows.Forms.PictureBox();
            this.PbTurnoC = new System.Windows.Forms.PictureBox();
            this.PbTurnoD = new System.Windows.Forms.PictureBox();
            this.PbTurnoA = new System.Windows.Forms.PictureBox();
            this.LblPlayer = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // PbCarta1
            // 
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
            this.BtnHabilitarLabel.Location = new System.Drawing.Point(723, 322);
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
            this.TxtLastData.Location = new System.Drawing.Point(650, 369);
            this.TxtLastData.Name = "TxtLastData";
            this.TxtLastData.Size = new System.Drawing.Size(134, 20);
            this.TxtLastData.TabIndex = 8;
            this.TxtLastData.Visible = false;
            // 
            // SpPuertosGame
            // 
            this.SpPuertosGame.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibidoGame);
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
            this.LblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.Location = new System.Drawing.Point(44, 48);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(0, 42);
            this.LblPlayer.TabIndex = 14;
            // 
            // TrucoFormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "TrucoFormGame";
            this.Text = "TrucoFormGame";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnHabilitarLabel;
        public System.Windows.Forms.TextBox TxtLastData;
        public System.IO.Ports.SerialPort SpPuertosGame;
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
    }
}