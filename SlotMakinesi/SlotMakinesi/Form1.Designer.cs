
namespace SlotMakinesi
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
            this.components = new System.ComponentModel.Container();
            this.labelKutu1 = new System.Windows.Forms.Label();
            this.labelKutu2 = new System.Windows.Forms.Label();
            this.labelKutu3 = new System.Windows.Forms.Label();
            this.buttonBaslat = new System.Windows.Forms.Button();
            this.buttonDurdur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelKutu1
            // 
            this.labelKutu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKutu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKutu1.Location = new System.Drawing.Point(115, 95);
            this.labelKutu1.Name = "labelKutu1";
            this.labelKutu1.Size = new System.Drawing.Size(100, 85);
            this.labelKutu1.TabIndex = 0;
            this.labelKutu1.Text = "0";
            this.labelKutu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKutu2
            // 
            this.labelKutu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKutu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKutu2.Location = new System.Drawing.Point(232, 95);
            this.labelKutu2.Name = "labelKutu2";
            this.labelKutu2.Size = new System.Drawing.Size(100, 85);
            this.labelKutu2.TabIndex = 1;
            this.labelKutu2.Text = "0";
            this.labelKutu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKutu3
            // 
            this.labelKutu3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKutu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKutu3.Location = new System.Drawing.Point(349, 95);
            this.labelKutu3.Name = "labelKutu3";
            this.labelKutu3.Size = new System.Drawing.Size(100, 85);
            this.labelKutu3.TabIndex = 2;
            this.labelKutu3.Text = "0";
            this.labelKutu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBaslat
            // 
            this.buttonBaslat.Location = new System.Drawing.Point(198, 200);
            this.buttonBaslat.Name = "buttonBaslat";
            this.buttonBaslat.Size = new System.Drawing.Size(75, 23);
            this.buttonBaslat.TabIndex = 3;
            this.buttonBaslat.Text = "Başlat";
            this.buttonBaslat.UseVisualStyleBackColor = true;
            this.buttonBaslat.Click += new System.EventHandler(this.buttonBaslat_Click);
            // 
            // buttonDurdur
            // 
            this.buttonDurdur.Location = new System.Drawing.Point(279, 200);
            this.buttonDurdur.Name = "buttonDurdur";
            this.buttonDurdur.Size = new System.Drawing.Size(75, 23);
            this.buttonDurdur.TabIndex = 4;
            this.buttonDurdur.Text = "Durdur";
            this.buttonDurdur.UseVisualStyleBackColor = true;
            this.buttonDurdur.Click += new System.EventHandler(this.buttonDurdur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.buttonDurdur);
            this.Controls.Add(this.buttonBaslat);
            this.Controls.Add(this.labelKutu3);
            this.Controls.Add(this.labelKutu2);
            this.Controls.Add(this.labelKutu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKutu1;
        private System.Windows.Forms.Label labelKutu2;
        private System.Windows.Forms.Label labelKutu3;
        private System.Windows.Forms.Button buttonBaslat;
        private System.Windows.Forms.Button buttonDurdur;
        private System.Windows.Forms.Timer timer1;
    }
}

