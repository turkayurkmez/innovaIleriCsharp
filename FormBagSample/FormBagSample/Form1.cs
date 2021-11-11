using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBagSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.Gonderilecek = "Deneme";
            form2.FormBag.OlduMu = false;
            form2.FormBag.BirFotograf = pictureBox1.Image;

            Form3 form3 = new Form3();
            form3.FormBag.Text = "Bu veri Form1'den geldi!";


            form3.Show();

            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ExpandObject.Message = "DynamicObject yerine hazır yazılmışı var";
            form2.ExpandObject.Getir = new Action<string>((x) => MessageBox.Show(x));
            form2.ExpandObject.Topla = new Func<int, int, int>((a, b) => a + b);

            form2.Show();
        }
    }
}
