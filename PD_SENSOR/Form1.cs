using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PD_SENSOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = int.Parse(this.textBox1.Text)*1000;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = int.Parse(this.textBox1.Text) * 1000;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TrackTemperatura.Value = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            TrackDureza.Value = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            TrackNivel.Value = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            TrackPH.Value = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            TrackTransparencia.Value = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            TrackAlcalinidade.Value = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            TrackTemperatura.Update();
            TrackDureza.Update();
            TrackNivel.Update();
            TrackPH.Update();
            TrackTransparencia.Update();
            TrackAlcalinidade.Update();
        }
    }
}
