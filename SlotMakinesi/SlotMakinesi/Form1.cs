using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Burası 1 msn'de bir çalışacak.
            //Üç adet rastgele sayı seçmeli.
            //Bu sayıları, kutulara atmalı.
            Random rastgeleSayiUretici = new Random();
            int sayi1 = rastgeleSayiUretici.Next(1, 10);
            int sayi2 = rastgeleSayiUretici.Next(1, 10);
            int sayi3 = rastgeleSayiUretici.Next(1, 10);

            labelKutu1.Text = sayi1.ToString();
            labelKutu2.Text = sayi2.ToString();
            labelKutu3.Text = sayi3.ToString();





        }

        private void buttonBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonBaslat.Text = "Durdur";
        }

        private void buttonDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            //3 kutu da birbirinin ayınısı ise... 
            //
            if (labelKutu1.Text == labelKutu2.Text && labelKutu2.Text == labelKutu3.Text)
            {
                MessageBox.Show("Tebrikler!");
            }
            else if (labelKutu1.Text == labelKutu2.Text || labelKutu1.Text == labelKutu3.Text || labelKutu2.Text == labelKutu3.Text)
            {
                MessageBox.Show("sadece 2 bildiniz. Bir kere daha deneyin");
            }
            else
            {
                MessageBox.Show("Kaybettiniz!");
            }

        }
    }
}
