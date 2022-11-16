namespace bilgi_yarışması_1._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CEVAP_A = new System.Windows.Forms.Button();
            this.CEVAP_B = new System.Windows.Forms.Button();
            this.CEVAP_C = new System.Windows.Forms.Button();
            this.CEVAP_D = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sorusayisi = new System.Windows.Forms.Label();
            this.dogrusayisi = new System.Windows.Forms.Label();
            this.yanlissayisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VERILENCEVAP = new System.Windows.Forms.Label();
            this.DOGRUCEVAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(289, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // CEVAP_A
            // 
            this.CEVAP_A.Location = new System.Drawing.Point(30, 106);
            this.CEVAP_A.Name = "CEVAP_A";
            this.CEVAP_A.Size = new System.Drawing.Size(75, 23);
            this.CEVAP_A.TabIndex = 1;
            this.CEVAP_A.Text = "CEVAP A";
            this.CEVAP_A.UseVisualStyleBackColor = true;
            this.CEVAP_A.Click += new System.EventHandler(this.CEVAP_A_Click);
            // 
            // CEVAP_B
            // 
            this.CEVAP_B.Location = new System.Drawing.Point(139, 106);
            this.CEVAP_B.Name = "CEVAP_B";
            this.CEVAP_B.Size = new System.Drawing.Size(75, 23);
            this.CEVAP_B.TabIndex = 2;
            this.CEVAP_B.Text = "CEVAP B";
            this.CEVAP_B.UseVisualStyleBackColor = true;
            this.CEVAP_B.Click += new System.EventHandler(this.CEVAP_B_Click);
            // 
            // CEVAP_C
            // 
            this.CEVAP_C.Location = new System.Drawing.Point(30, 135);
            this.CEVAP_C.Name = "CEVAP_C";
            this.CEVAP_C.Size = new System.Drawing.Size(75, 23);
            this.CEVAP_C.TabIndex = 3;
            this.CEVAP_C.Text = "CEVAP C";
            this.CEVAP_C.UseVisualStyleBackColor = true;
            this.CEVAP_C.Click += new System.EventHandler(this.CEVAP_C_Click);
            // 
            // CEVAP_D
            // 
            this.CEVAP_D.Location = new System.Drawing.Point(139, 135);
            this.CEVAP_D.Name = "CEVAP_D";
            this.CEVAP_D.Size = new System.Drawing.Size(75, 23);
            this.CEVAP_D.TabIndex = 4;
            this.CEVAP_D.Text = "CEVAP D";
            this.CEVAP_D.UseVisualStyleBackColor = true;
            this.CEVAP_D.Click += new System.EventHandler(this.CEVAP_D_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(410, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sonraki Soru";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yanlış:";
            // 
            // sorusayisi
            // 
            this.sorusayisi.AutoSize = true;
            this.sorusayisi.Location = new System.Drawing.Point(477, 23);
            this.sorusayisi.Name = "sorusayisi";
            this.sorusayisi.Size = new System.Drawing.Size(13, 13);
            this.sorusayisi.TabIndex = 9;
            this.sorusayisi.Text = "0";
            // 
            // dogrusayisi
            // 
            this.dogrusayisi.AutoSize = true;
            this.dogrusayisi.Location = new System.Drawing.Point(477, 52);
            this.dogrusayisi.Name = "dogrusayisi";
            this.dogrusayisi.Size = new System.Drawing.Size(13, 13);
            this.dogrusayisi.TabIndex = 10;
            this.dogrusayisi.Text = "0";
            // 
            // yanlissayisi
            // 
            this.yanlissayisi.AutoSize = true;
            this.yanlissayisi.Location = new System.Drawing.Point(477, 77);
            this.yanlissayisi.Name = "yanlissayisi";
            this.yanlissayisi.Size = new System.Drawing.Size(13, 13);
            this.yanlissayisi.TabIndex = 11;
            this.yanlissayisi.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(480, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // VERILENCEVAP
            // 
            this.VERILENCEVAP.AutoSize = true;
            this.VERILENCEVAP.Location = new System.Drawing.Point(420, 244);
            this.VERILENCEVAP.Name = "VERILENCEVAP";
            this.VERILENCEVAP.Size = new System.Drawing.Size(88, 13);
            this.VERILENCEVAP.TabIndex = 14;
            this.VERILENCEVAP.Text = "VERILENCEVAP";
            this.VERILENCEVAP.Visible = false;
            // 
            // DOGRUCEVAP
            // 
            this.DOGRUCEVAP.AutoSize = true;
            this.DOGRUCEVAP.Location = new System.Drawing.Point(530, 244);
            this.DOGRUCEVAP.Name = "DOGRUCEVAP";
            this.DOGRUCEVAP.Size = new System.Drawing.Size(82, 13);
            this.DOGRUCEVAP.TabIndex = 15;
            this.DOGRUCEVAP.Text = "DOGRUCEVAP";
            this.DOGRUCEVAP.Visible = false;
            this.DOGRUCEVAP.Click += new System.EventHandler(this.DOGRUCEVAP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DOGRUCEVAP);
            this.Controls.Add(this.VERILENCEVAP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yanlissayisi);
            this.Controls.Add(this.dogrusayisi);
            this.Controls.Add(this.sorusayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CEVAP_D);
            this.Controls.Add(this.CEVAP_C);
            this.Controls.Add(this.CEVAP_B);
            this.Controls.Add(this.CEVAP_A);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CEVAP_A;
        private System.Windows.Forms.Button CEVAP_B;
        private System.Windows.Forms.Button CEVAP_C;
        private System.Windows.Forms.Button CEVAP_D;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sorusayisi;
        private System.Windows.Forms.Label dogrusayisi;
        private System.Windows.Forms.Label yanlissayisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label VERILENCEVAP;
        private System.Windows.Forms.Label DOGRUCEVAP;
    }
}

