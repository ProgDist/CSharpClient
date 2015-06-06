using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            send_values(TrackTemperatura.Value, TrackDureza.Value, TrackNivel.Value, TrackPH.Value, TrackTransparencia.Value, TrackAlcalinidade.Value);
        }

        private void send_values(int temperatura, int dureza, int nivel, int ph, int transparencia, int alcalinidade)
        {
            string URI = "http://premium-valor-94418.appspot.com/dados";
            string myParameters = "temperatura="+temperatura.ToString()+"&ph="+ph.ToString()+"&dureza="+dureza.ToString()+"&alcalinidade="+alcalinidade.ToString()+"&nivelo2="+nivel.ToString()+"&transparencia="+transparencia.ToString();

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);

                textBox2.Text = textBox2.Text + HtmlResult + Environment.NewLine;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
