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
    public partial class Form3 : Form, IIncludeFormBag
    {
        public Form3()
        {
            InitializeComponent();
        }

        public dynamic FormBag { get; set; } = new FormBag();

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = FormBag.Text;
        }
    }
}
