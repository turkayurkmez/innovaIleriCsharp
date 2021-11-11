using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBagSample
{
    public partial class Form2 : Form, IIncludeFormBag
    {
        public dynamic FormBag { get; set; } = new FormBag();
        public dynamic ExpandObject { get; set; } = new ExpandoObject();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(FormBag.Gonderilecek);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = FormBag.BirFotograf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = ExpandObject.Message;
            ExpandObject.Getir("bu bir dinamik metot!");
            int sonuc = ExpandObject.Topla(3, 5);
            MessageBox.Show(sonuc.ToString());
        }
    }
}
