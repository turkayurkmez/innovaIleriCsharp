using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 8;
            int sonuc = x.KaresiniAl();
            int baskaSonuc = x.UssunuAl(4);

            label1.Text = sonuc.ToString();
            label2.Text = baskaSonuc.ToString();

            DayOfWeek value = (DayOfWeek)6;
            MessageBox.Show(value.ToString());
            MessageBox.Show(DateTime.Now.TurkceGunGetir());
        }
    }
}
