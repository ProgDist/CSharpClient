namespace PD_SENSOR
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TrackTemperatura = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackPH = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackDureza = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackAlcalinidade = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackNivel = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.TrackTransparencia = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TrackTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackDureza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAlcalinidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTransparencia)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrackTemperatura
            // 
            this.TrackTemperatura.Location = new System.Drawing.Point(9, 84);
            this.TrackTemperatura.Maximum = 100;
            this.TrackTemperatura.Name = "TrackTemperatura";
            this.TrackTemperatura.Size = new System.Drawing.Size(104, 45);
            this.TrackTemperatura.TabIndex = 2;
            this.TrackTemperatura.TickFrequency = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TrackPH
            // 
            this.TrackPH.Location = new System.Drawing.Point(151, 84);
            this.TrackPH.Maximum = 100;
            this.TrackPH.Name = "TrackPH";
            this.TrackPH.Size = new System.Drawing.Size(104, 45);
            this.TrackPH.TabIndex = 4;
            this.TrackPH.TickFrequency = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dureza";
            // 
            // TrackDureza
            // 
            this.TrackDureza.Location = new System.Drawing.Point(9, 156);
            this.TrackDureza.Maximum = 100;
            this.TrackDureza.Name = "TrackDureza";
            this.TrackDureza.Size = new System.Drawing.Size(104, 45);
            this.TrackDureza.TabIndex = 7;
            this.TrackDureza.TickFrequency = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempo(seg):";
            // 
            // TrackAlcalinidade
            // 
            this.TrackAlcalinidade.Location = new System.Drawing.Point(151, 156);
            this.TrackAlcalinidade.Maximum = 100;
            this.TrackAlcalinidade.Name = "TrackAlcalinidade";
            this.TrackAlcalinidade.Size = new System.Drawing.Size(104, 45);
            this.TrackAlcalinidade.TabIndex = 10;
            this.TrackAlcalinidade.TickFrequency = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alcalinidade";
            // 
            // TrackNivel
            // 
            this.TrackNivel.Location = new System.Drawing.Point(9, 228);
            this.TrackNivel.Maximum = 100;
            this.TrackNivel.Name = "TrackNivel";
            this.TrackNivel.Size = new System.Drawing.Size(104, 45);
            this.TrackNivel.TabIndex = 12;
            this.TrackNivel.TickFrequency = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nivel O²";
            // 
            // TrackTransparencia
            // 
            this.TrackTransparencia.Location = new System.Drawing.Point(151, 228);
            this.TrackTransparencia.Maximum = 100;
            this.TrackTransparencia.Name = "TrackTransparencia";
            this.TrackTransparencia.Size = new System.Drawing.Size(104, 45);
            this.TrackTransparencia.TabIndex = 14;
            this.TrackTransparencia.TickFrequency = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Transparência";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 278);
            this.Controls.Add(this.TrackTransparencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TrackNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TrackAlcalinidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TrackDureza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackPH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackTemperatura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrackTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackDureza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAlcalinidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTransparencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar TrackTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackPH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TrackDureza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackAlcalinidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TrackNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar TrackTransparencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}

