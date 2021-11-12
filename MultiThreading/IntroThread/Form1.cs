using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroThread
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Stopwatch stopwatch;
        private void buttonSingleCounter_Click(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();
            for (int i = 0; i <= 10000; i++)
            {
                labelSingle.Text = i.ToString();
            }
            stopwatch.Stop();
            labelGecenSure.Text = stopwatch.ElapsedMilliseconds.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çalıştım ben!");
        }

        Thread thread = null;
        private void buttonMulti_Click(object sender, EventArgs e)
        {

            thread = new Thread(new ThreadStart(Tcounter));
            thread.Start();

            // thread.Join();
        }

        void Tcounter()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i <= 10000; i++)
            {
                labelMulti.Text = i.ToString();
            }
            stopwatch.Stop();
            label1.Text = stopwatch.ElapsedMilliseconds.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
            }

        }

        private async void buttonTask_Click(object sender, EventArgs e)
        {

           await counter();
            MessageBox.Show("Görevler bitti");

           

        }

        async Task counter()
        {
            for (int j = 0; j < 3; j++)
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i <= 5000; i++)
                    {
                        labelTask.Text = i.ToString();
                    }
                });
                MessageBox.Show("Ok");  
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            label1.Text = "Yükleniyor...";

            var response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;
            Thread.Sleep(5000);
            label1.Text = "Yüklendi";
            var result  =  response.Content.ReadAsStringAsync().Result;
            richTextBoxResponse.Text = result;

        }

        private async Task CloseMessage()
        {
            //Bir form kapatılıyor!
        }
    }
}
