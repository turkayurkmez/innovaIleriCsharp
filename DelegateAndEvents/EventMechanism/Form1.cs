using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            productBusiness.ProductAdded += ProductBusiness_ProductAdded;
                ;
            productBusiness.AddProduct(new Product { Name = "Test Data" });
        }

        private void ProductBusiness_ProductAdded(object sender, ProductAddedEventArgs e)
        {
            MessageBox.Show($"{e.Operator} isimli kişi {e.CreatedDate} tarihinde, {e.Product.Name} isimli ürünü ekledi");
        }
    }
}
