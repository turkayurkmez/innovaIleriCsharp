
namespace IntroThread
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
            this.buttonSingleCounter = new System.Windows.Forms.Button();
            this.labelSingle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.labelMulti = new System.Windows.Forms.Label();
            this.labelGecenSure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSingleCounter
            // 
            this.buttonSingleCounter.Location = new System.Drawing.Point(94, 98);
            this.buttonSingleCounter.Name = "buttonSingleCounter";
            this.buttonSingleCounter.Size = new System.Drawing.Size(173, 23);
            this.buttonSingleCounter.TabIndex = 0;
            this.buttonSingleCounter.Text = "Single Thread Counter";
            this.buttonSingleCounter.UseVisualStyleBackColor = true;
            this.buttonSingleCounter.Click += new System.EventHandler(this.buttonSingleCounter_Click);
            // 
            // labelSingle
            // 
            this.labelSingle.AutoSize = true;
            this.labelSingle.Location = new System.Drawing.Point(282, 103);
            this.labelSingle.Name = "labelSingle";
            this.labelSingle.Size = new System.Drawing.Size(16, 13);
            this.labelSingle.TabIndex = 1;
            this.labelSingle.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(94, 141);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(173, 23);
            this.buttonMulti.TabIndex = 3;
            this.buttonMulti.Text = "Multi Thread Counter";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // labelMulti
            // 
            this.labelMulti.AutoSize = true;
            this.labelMulti.Location = new System.Drawing.Point(282, 146);
            this.labelMulti.Name = "labelMulti";
            this.labelMulti.Size = new System.Drawing.Size(16, 13);
            this.labelMulti.TabIndex = 4;
            this.labelMulti.Text = "...";
            // 
            // labelGecenSure
            // 
            this.labelGecenSure.AutoSize = true;
            this.labelGecenSure.Location = new System.Drawing.Point(324, 108);
            this.labelGecenSure.Name = "labelGecenSure";
            this.labelGecenSure.Size = new System.Drawing.Size(35, 13);
            this.labelGecenSure.TabIndex = 5;
            this.labelGecenSure.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGecenSure);
            this.Controls.Add(this.labelMulti);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSingle);
            this.Controls.Add(this.buttonSingleCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSingleCounter;
        private System.Windows.Forms.Label labelSingle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Label labelMulti;
        private System.Windows.Forms.Label labelGecenSure;
        private System.Windows.Forms.Label label1;
    }
}

