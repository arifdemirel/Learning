namespace Bonus_Okul
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnogretmen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnogrenci = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnogretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numara:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnogretmen
            // 
            this.btnogretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogretmen.Image = ((System.Drawing.Image)(resources.GetObject("btnogretmen.Image")));
            this.btnogretmen.Location = new System.Drawing.Point(228, 12);
            this.btnogretmen.Name = "btnogretmen";
            this.btnogretmen.Size = new System.Drawing.Size(154, 87);
            this.btnogretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnogretmen.TabIndex = 10;
            this.btnogretmen.TabStop = false;
            this.btnogretmen.Click += new System.EventHandler(this.btnogretmen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Öğretmen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci";
            // 
            // btnogrenci
            // 
            this.btnogrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrenci.Image = ((System.Drawing.Image)(resources.GetObject("btnogrenci.Image")));
            this.btnogrenci.Location = new System.Drawing.Point(12, 12);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(161, 87);
            this.btnogrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnogrenci.TabIndex = 7;
            this.btnogrenci.TabStop = false;
            this.btnogrenci.Click += new System.EventHandler(this.btnogrenci_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnogretmen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnogrenci);
            this.Name = "form1";
            this.Text = "form1";
            this.Click += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnogretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnogrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btnogretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnogrenci;
    }
}