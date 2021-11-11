using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
            
            thread = new Thread(new ThreadStart(counter));            
            thread.Start();
          
            // thread.Join();
        }

        void counter()
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
    }
}
