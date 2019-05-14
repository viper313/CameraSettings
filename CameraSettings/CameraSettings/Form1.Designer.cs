namespace CameraSettings
{
    partial class Form1
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
            this.ibOrginal = new Emgu.CV.UI.ImageBox();
            this.ibKopia = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.numJasnosc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnPauza2 = new System.Windows.Forms.Button();
            this.btnPauza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbKanaly = new System.Windows.Forms.GroupBox();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.rbRgb = new System.Windows.Forms.RadioButton();
            this.btnLUT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numKontrast = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ibOrginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibKopia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJasnosc)).BeginInit();
            this.gbKanaly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrast)).BeginInit();
            this.SuspendLayout();
            // 
            // ibOrginal
            // 
            this.ibOrginal.Location = new System.Drawing.Point(34, 26);
            this.ibOrginal.Name = "ibOrginal";
            this.ibOrginal.Size = new System.Drawing.Size(480, 360);
            this.ibOrginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibOrginal.TabIndex = 2;
            this.ibOrginal.TabStop = false;
            // 
            // ibKopia
            // 
            this.ibKopia.Location = new System.Drawing.Point(596, 26);
            this.ibKopia.Name = "ibKopia";
            this.ibKopia.Size = new System.Drawing.Size(480, 360);
            this.ibKopia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibKopia.TabIndex = 3;
            this.ibKopia.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(111, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 39);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numJasnosc
            // 
            this.numJasnosc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.numJasnosc.Location = new System.Drawing.Point(1089, 154);
            this.numJasnosc.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numJasnosc.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.numJasnosc.Name = "numJasnosc";
            this.numJasnosc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numJasnosc.Size = new System.Drawing.Size(160, 20);
            this.numJasnosc.TabIndex = 5;
            this.numJasnosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1095, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jasność (-127:127)";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(337, 404);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 38);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(727, 415);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(100, 39);
            this.btnStart2.TabIndex = 4;
            this.btnStart2.Text = "Start2";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(989, 416);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(87, 38);
            this.btnStop2.TabIndex = 7;
            this.btnStop2.Text = "Stop2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnPauza2
            // 
            this.btnPauza2.Location = new System.Drawing.Point(867, 416);
            this.btnPauza2.Name = "btnPauza2";
            this.btnPauza2.Size = new System.Drawing.Size(90, 37);
            this.btnPauza2.TabIndex = 8;
            this.btnPauza2.Text = "Pauza2";
            this.btnPauza2.UseVisualStyleBackColor = true;
            this.btnPauza2.Click += new System.EventHandler(this.btnPauza2_Click);
            // 
            // btnPauza
            // 
            this.btnPauza.Location = new System.Drawing.Point(228, 404);
            this.btnPauza.Name = "btnPauza";
            this.btnPauza.Size = new System.Drawing.Size(89, 38);
            this.btnPauza.TabIndex = 9;
            this.btnPauza.Text = "Pauza";
            this.btnPauza.UseVisualStyleBackColor = true;
            this.btnPauza.Click += new System.EventHandler(this.btnPauza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Przechwytywanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zmodyfikowany";
            // 
            // gbKanaly
            // 
            this.gbKanaly.Controls.Add(this.rbGray);
            this.gbKanaly.Controls.Add(this.rbRgb);
            this.gbKanaly.Location = new System.Drawing.Point(1093, 31);
            this.gbKanaly.Name = "gbKanaly";
            this.gbKanaly.Size = new System.Drawing.Size(153, 85);
            this.gbKanaly.TabIndex = 12;
            this.gbKanaly.TabStop = false;
            this.gbKanaly.Text = "Kanały";
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Location = new System.Drawing.Point(19, 51);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(47, 17);
            this.rbGray.TabIndex = 1;
            this.rbGray.Text = "Gray";
            this.rbGray.UseVisualStyleBackColor = true;
            // 
            // rbRgb
            // 
            this.rbRgb.AutoSize = true;
            this.rbRgb.Checked = true;
            this.rbRgb.Location = new System.Drawing.Point(19, 19);
            this.rbRgb.Name = "rbRgb";
            this.rbRgb.Size = new System.Drawing.Size(48, 17);
            this.rbRgb.TabIndex = 0;
            this.rbRgb.TabStop = true;
            this.rbRgb.Text = "RGB";
            this.rbRgb.UseVisualStyleBackColor = true;
            // 
            // btnLUT
            // 
            this.btnLUT.Location = new System.Drawing.Point(1261, 163);
            this.btnLUT.Name = "btnLUT";
            this.btnLUT.Size = new System.Drawing.Size(99, 59);
            this.btnLUT.TabIndex = 13;
            this.btnLUT.Text = "LUT";
            this.btnLUT.UseVisualStyleBackColor = true;
            this.btnLUT.Click += new System.EventHandler(this.btnLUT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1095, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kontrast (0:127)";
            // 
            // numKontrast
            // 
            this.numKontrast.Location = new System.Drawing.Point(1089, 202);
            this.numKontrast.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numKontrast.Name = "numKontrast";
            this.numKontrast.Size = new System.Drawing.Size(159, 20);
            this.numKontrast.TabIndex = 15;
            this.numKontrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 516);
            this.Controls.Add(this.numKontrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLUT);
            this.Controls.Add(this.gbKanaly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPauza);
            this.Controls.Add(this.btnPauza2);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numJasnosc);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ibKopia);
            this.Controls.Add(this.ibOrginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ibOrginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibKopia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJasnosc)).EndInit();
            this.gbKanaly.ResumeLayout(false);
            this.gbKanaly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibOrginal;
        private Emgu.CV.UI.ImageBox ibKopia;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numJasnosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnPauza2;
        private System.Windows.Forms.Button btnPauza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbKanaly;
        private System.Windows.Forms.RadioButton rbGray;
        private System.Windows.Forms.RadioButton rbRgb;
        private System.Windows.Forms.Button btnLUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKontrast;
    }
}

