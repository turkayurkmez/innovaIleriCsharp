
namespace Draw.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRenk = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(240, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 319);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginToolStripMenuItem,
            this.sekillerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pluginToolStripMenuItem
            // 
            this.pluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginLoadToolStripMenuItem});
            this.pluginToolStripMenuItem.Name = "pluginToolStripMenuItem";
            this.pluginToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pluginToolStripMenuItem.Text = "Plugin ";
            // 
            // pluginLoadToolStripMenuItem
            // 
            this.pluginLoadToolStripMenuItem.Name = "pluginLoadToolStripMenuItem";
            this.pluginLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pluginLoadToolStripMenuItem.Text = "Plugin Yükle";
            this.pluginLoadToolStripMenuItem.Click += new System.EventHandler(this.pluginLoadToolStripMenuItem_Click);
            // 
            // sekillerToolStripMenuItem
            // 
            this.sekillerToolStripMenuItem.Name = "sekillerToolStripMenuItem";
            this.sekillerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sekillerToolStripMenuItem.Text = "Şekiller";
            // 
            // buttonRenk
            // 
            this.buttonRenk.Location = new System.Drawing.Point(570, 36);
            this.buttonRenk.Name = "buttonRenk";
            this.buttonRenk.Size = new System.Drawing.Size(75, 23);
            this.buttonRenk.TabIndex = 2;
            this.buttonRenk.Text = "Renk seçiniz...";
            this.buttonRenk.UseVisualStyleBackColor = true;
            this.buttonRenk.Click += new System.EventHandler(this.buttonRenk_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(104, 38);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(225, 38);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 4;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(443, 38);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(337, 38);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonRenk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekillerToolStripMenuItem;
        private System.Windows.Forms.Button buttonRenk;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
    }
}

