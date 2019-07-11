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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtLastData = new System.Windows.Forms.TextBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartaC)).BeginInit();
            this.SuspendLayout();
            // 
            // PbCarta1
            // 
            this.PbCarta1.Location = new System.Drawing.Point(248, 302);
            this.PbCarta1.Name = "PbCarta1";
            this.PbCarta1.Size = new System.Drawing.Size(66, 96);
            this.PbCarta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta1.TabIndex = 0;
            this.PbCarta1.TabStop = false;
            // 
            // PbCarta2
            // 
            this.PbCarta2.Location = new System.Drawing.Point(367, 302);
            this.PbCarta2.Name = "PbCarta2";
            this.PbCarta2.Size = new System.Drawing.Size(66, 96);
            this.PbCarta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta2.TabIndex = 1;
            this.PbCarta2.TabStop = false;
            // 
            // PbCarta3
            // 
            this.PbCarta3.Location = new System.Drawing.Point(481, 302);
            this.PbCarta3.Name = "PbCarta3";
            this.PbCarta3.Size = new System.Drawing.Size(66, 96);
            this.PbCarta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarta3.TabIndex = 2;
            this.PbCarta3.TabStop = false;
            // 
            // PbCartaA
            // 
            this.PbCartaA.Location = new System.Drawing.Point(367, 186);
            this.PbCartaA.Name = "PbCartaA";
            this.PbCartaA.Size = new System.Drawing.Size(66, 96);
            this.PbCartaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaA.TabIndex = 3;
            this.PbCartaA.TabStop = false;
            // 
            // PbCartaD
            // 
            this.PbCartaD.Location = new System.Drawing.Point(176, 120);
            this.PbCartaD.Name = "PbCartaD";
            this.PbCartaD.Size = new System.Drawing.Size(66, 96);
            this.PbCartaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaD.TabIndex = 4;
            this.PbCartaD.TabStop = false;
            // 
            // PbCartaB
            // 
            this.PbCartaB.Location = new System.Drawing.Point(546, 120);
            this.PbCartaB.Name = "PbCartaB";
            this.PbCartaB.Size = new System.Drawing.Size(66, 96);
            this.PbCartaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaB.TabIndex = 5;
            this.PbCartaB.TabStop = false;
            // 
            // PbCartaC
            // 
            this.PbCartaC.Location = new System.Drawing.Point(367, 21);
            this.PbCartaC.Name = "PbCartaC";
            this.PbCartaC.Size = new System.Drawing.Size(66, 96);
            this.PbCartaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartaC.TabIndex = 6;
            this.PbCartaC.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtLastData
            // 
            this.TxtLastData.Location = new System.Drawing.Point(650, 369);
            this.TxtLastData.Name = "TxtLastData";
            this.TxtLastData.Size = new System.Drawing.Size(134, 20);
            this.TxtLastData.TabIndex = 8;
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // TrucoFormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtLastData);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCarta1;
        private System.Windows.Forms.PictureBox PbCarta2;
        private System.Windows.Forms.PictureBox PbCarta3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox PbCartaA;
        private System.Windows.Forms.PictureBox PbCartaD;
        private System.Windows.Forms.PictureBox PbCartaB;
        private System.Windows.Forms.PictureBox PbCartaC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtLastData;
        private System.IO.Ports.SerialPort SpPuertos;
    }
}