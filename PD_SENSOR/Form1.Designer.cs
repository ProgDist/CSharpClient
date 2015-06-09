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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(91, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_click);
            // 
            // TrackTemperatura
            // 
            this.TrackTemperatura.Location = new System.Drawing.Point(8, 99);
            this.TrackTemperatura.Maximum = 50;
            this.TrackTemperatura.Name = "TrackTemperatura";
            this.TrackTemperatura.Size = new System.Drawing.Size(104, 45);
            this.TrackTemperatura.TabIndex = 2;
            this.TrackTemperatura.TickFrequency = 5;
            this.TrackTemperatura.Scroll += new System.EventHandler(this.temp_scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura";
            // 
            // TrackPH
            // 
            this.TrackPH.Location = new System.Drawing.Point(150, 99);
            this.TrackPH.Name = "TrackPH";
            this.TrackPH.Size = new System.Drawing.Size(104, 45);
            this.TrackPH.TabIndex = 4;
            this.TrackPH.TickFrequency = 2;
            this.TrackPH.Scroll += new System.EventHandler(this.ph_scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ph";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dureza";
            // 
            // TrackDureza
            // 
            this.TrackDureza.Location = new System.Drawing.Point(8, 171);
            this.TrackDureza.Maximum = 100;
            this.TrackDureza.Name = "TrackDureza";
            this.TrackDureza.Size = new System.Drawing.Size(104, 45);
            this.TrackDureza.TabIndex = 7;
            this.TrackDureza.TickFrequency = 10;
            this.TrackDureza.Scroll += new System.EventHandler(this.dureza_scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempo(seg):";
            // 
            // TrackAlcalinidade
            // 
            this.TrackAlcalinidade.Location = new System.Drawing.Point(150, 171);
            this.TrackAlcalinidade.Maximum = 120;
            this.TrackAlcalinidade.Name = "TrackAlcalinidade";
            this.TrackAlcalinidade.Size = new System.Drawing.Size(104, 45);
            this.TrackAlcalinidade.TabIndex = 10;
            this.TrackAlcalinidade.TickFrequency = 10;
            this.TrackAlcalinidade.Scroll += new System.EventHandler(this.alcalinidade_scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alcalinidade";
            // 
            // TrackNivel
            // 
            this.TrackNivel.Location = new System.Drawing.Point(8, 243);
            this.TrackNivel.Maximum = 15;
            this.TrackNivel.Name = "TrackNivel";
            this.TrackNivel.Size = new System.Drawing.Size(104, 45);
            this.TrackNivel.TabIndex = 3;
            this.TrackNivel.TickFrequency = 3;
            this.TrackNivel.Scroll += new System.EventHandler(this.nivel_scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nivel O²";
            // 
            // TrackTransparencia
            // 
            this.TrackTransparencia.Location = new System.Drawing.Point(150, 243);
            this.TrackTransparencia.Maximum = 50;
            this.TrackTransparencia.Name = "TrackTransparencia";
            this.TrackTransparencia.Size = new System.Drawing.Size(104, 45);
            this.TrackTransparencia.TabIndex = 5;
            this.TrackTransparencia.TickFrequency = 5;
            this.TrackTransparencia.Scroll += new System.EventHandler(this.transparencia_scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 219);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 295);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(242, 88);
            this.textBox2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stop_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "ENVIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.enviar_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

