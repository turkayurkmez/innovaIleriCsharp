using Draw.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, Plug> loadedPlugins = new Dictionary<string, Plug>();
        private void pluginLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Application.StartupPath;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //1. Plugin'in ismi.
                //2. Plugin'in adresi
                //3. Plugin'in namespace.class (fullname) formatında tipi
                List<Plug> plugs = PluginHelper.GetPlugins(folderBrowserDialog.SelectedPath);
                plugs.ForEach(plug =>
                {
                    ToolStripItem toolStripItem = new ToolStripMenuItem(plug.Name);
                    sekillerToolStripMenuItem.DropDownItems.Add(toolStripItem);
                    toolStripItem.Click += ToolStripItem_Click;
                    loadedPlugins.Add(plug.Name, plug);
                });
            }
        }

        int width=50;
        int height=50;
        Color color=Color.Blue;
        int x=0;
        int y=0;
        private void ToolStripItem_Click(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Text;
            Plug plug = loadedPlugins[name];
            var plugObject = (IPlug)PluginHelper.CreateInstance(plug);
            plugObject.Draw(panel1.CreateGraphics(), new SolidBrush(color), x, y, width, height);

        }

        private void buttonRenk_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()==DialogResult.OK)
            {
                width = Convert.ToInt32(textBoxWidth.Text);
                height = Convert.ToInt32(textBoxHeight.Text);
                x = Convert.ToInt32(textBoxX.Text);
                y = Convert.ToInt32(textBoxY.Text);
                color = colorDialog.Color;

            }
        }
    }
}
