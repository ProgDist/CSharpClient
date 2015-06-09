using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace PD_CLIENTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "Digite seu Email (email@email.com)";
        }

        private void rel_total(object sender, EventArgs e)
        {
            string URI = "http://premium-valor-94418.appspot.com/relatoriobd";
            string myParameters = "";

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);

                textBox1.Text = HtmlResult.Replace("/", " ");
            }
        }

        private void rel_dia(object sender, EventArgs e)
        {
            DateTime data = dateTimePicker1.Value;
            string URI = "http://premium-valor-94418.appspot.com/relatoriobd/" + data.ToString("dd") + "/" + data.ToString("MM") + "/" + data.ToString("yyyy");
            string myParameters = "";

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);

                textBox1.Text = HtmlResult.Replace("/", " ");
            }
        }

        private void rel_l_total(object sender, EventArgs e)
        {
            string URI = "http://premium-valor-94418.appspot.com/relatorio";
            string myParameters = "";

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);

                textBox2.Text = HtmlResult;
            }
        }

        private void rel_l_dia(object sender, EventArgs e)
        {
            DateTime data = dateTimePicker2.Value;
            string URI = "http://premium-valor-94418.appspot.com/relatorio/" + data.ToString("dd") + "/" + data.ToString("MM") + "/" + data.ToString("yyyy");
            string myParameters = "";

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);

                textBox2.Text = HtmlResult;
            }
        }

        private void focus_enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void focus_leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Digite seu Email (email@email.com)";
            }
        }

        private void subscribe(object sender, EventArgs e)
        {
            if (textBox3.Text != "Digite seu Email (email@email.com)")
            {
                string URI = "http://premium-valor-94418.appspot.com/subscribe";
                string myParameters = "email=" + textBox3.Text;

                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string HtmlResult = wc.UploadString(URI, myParameters);

                    if (HtmlResult == "Email " + textBox3.Text + " cadastrado!")
                    {
                        MessageBox.Show("Email cadastrado!");
                    }
                    else
                    {
                        MessageBox.Show("Email já cadastrado!");
                    }
                }
            }

        }

        private void unsubscribe(object sender, EventArgs e)
        {
            if (textBox3.Text != "Digite seu Email (email@email.com)")
            {
                string URI = "http://premium-valor-94418.appspot.com/unsubscribe";
                string myParameters = "email=" + textBox3.Text;

                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string HtmlResult = wc.UploadString(URI, myParameters);

                    if (HtmlResult == "Email " + textBox3.Text + " removido!")
                    {
                        MessageBox.Show("Email removido!");
                    }
                    else
                    {
                        MessageBox.Show("Email não foi encontrado!");
                    }
                }
            }
        }
    }
}
