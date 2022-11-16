namespace bilgi_yarışması
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
            this.BTNA = new System.Windows.Forms.Button();
            this.BTNB = new System.Windows.Forms.Button();
            this.BTNC = new System.Windows.Forms.Button();
            this.BTND = new System.Windows.Forms.Button();
            this.BTNSONRAKI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLSORUNO = new System.Windows.Forms.Label();
            this.LBLDOGRU = new System.Windows.Forms.Label();
            this.LBLYANLIS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CEVAP = new System.Windows.Forms.Label();
            this.DOGRUCEVAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BTNA
            // 
            this.BTNA.Location = new System.Drawing.Point(26, 164);
            this.BTNA.Name = "BTNA";
            this.BTNA.Size = new System.Drawing.Size(75, 23);
            this.BTNA.TabIndex = 1;
            this.BTNA.Text = "A";
            this.BTNA.UseVisualStyleBackColor = true;
            this.BTNA.Click += new System.EventHandler(this.BTNA_Click);
            // 
            // BTNB
            // 
            this.BTNB.Location = new System.Drawing.Point(163, 164);
            this.BTNB.Name = "BTNB";
            this.BTNB.Size = new System.Drawing.Size(75, 23);
            this.BTNB.TabIndex = 2;
            this.BTNB.Text = "B";
            this.BTNB.UseVisualStyleBackColor = true;
            this.BTNB.Click += new System.EventHandler(this.BTNB_Click);
            // 
            // BTNC
            // 
            this.BTNC.Location = new System.Drawing.Point(26, 193);
            this.BTNC.Name = "BTNC";
            this.BTNC.Size = new System.Drawing.Size(75, 23);
            this.BTNC.TabIndex = 3;
            this.BTNC.Text = "C";
            this.BTNC.UseVisualStyleBackColor = true;
            // 
            // BTND
            // 
            this.BTND.Location = new System.Drawing.Point(163, 193);
            this.BTND.Name = "BTND";
            this.BTND.Size = new System.Drawing.Size(75, 23);
            this.BTND.TabIndex = 4;
            this.BTND.Text = "D";
            this.BTND.UseVisualStyleBackColor = true;
            // 
            // BTNSONRAKI
            // 
            this.BTNSONRAKI.Location = new System.Drawing.Point(357, 87);
            this.BTNSONRAKI.Name = "BTNSONRAKI";
            this.BTNSONRAKI.Size = new System.Drawing.Size(75, 23);
            this.BTNSONRAKI.TabIndex = 5;
            this.BTNSONRAKI.Text = "Sonraki";
            this.BTNSONRAKI.UseVisualStyleBackColor = true;
            this.BTNSONRAKI.Click += new System.EventHandler(this.BTNSONRAKI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yanlış:";
            // 
            // LBLSORUNO
            // 
            this.LBLSORUNO.AutoSize = true;
            this.LBLSORUNO.Location = new System.Drawing.Point(404, 9);
            this.LBLSORUNO.Name = "LBLSORUNO";
            this.LBLSORUNO.Size = new System.Drawing.Size(13, 13);
            this.LBLSORUNO.TabIndex = 9;
            this.LBLSORUNO.Text = "0";
            // 
            // LBLDOGRU
            // 
            this.LBLDOGRU.AutoSize = true;
            this.LBLDOGRU.Location = new System.Drawing.Point(403, 37);
            this.LBLDOGRU.Name = "LBLDOGRU";
            this.LBLDOGRU.Size = new System.Drawing.Size(13, 13);
            this.LBLDOGRU.TabIndex = 10;
            this.LBLDOGRU.Text = "0";
            // 
            // LBLYANLIS
            // 
            this.LBLYANLIS.AutoSize = true;
            this.LBLYANLIS.Location = new System.Drawing.Point(404, 62);
            this.LBLYANLIS.Name = "LBLYANLIS";
            this.LBLYANLIS.Size = new System.Drawing.Size(13, 13);
            this.LBLYANLIS.TabIndex = 11;
            this.LBLYANLIS.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 125);
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
            this.pictureBox2.Location = new System.Drawing.Point(463, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // CEVAP
            // 
            this.CEVAP.AutoSize = true;
            this.CEVAP.Location = new System.Drawing.Point(513, 284);
            this.CEVAP.Name = "CEVAP";
            this.CEVAP.Size = new System.Drawing.Size(35, 13);
            this.CEVAP.TabIndex = 14;
            this.CEVAP.Text = "label7";
            this.CEVAP.Visible = false;
            // 
            // DOGRUCEVAP
            // 
            this.DOGRUCEVAP.AutoSize = true;
            this.DOGRUCEVAP.Location = new System.Drawing.Point(568, 284);
            this.DOGRUCEVAP.Name = "DOGRUCEVAP";
            this.DOGRUCEVAP.Size = new System.Drawing.Size(35, 13);
            this.DOGRUCEVAP.TabIndex = 15;
            this.DOGRUCEVAP.Text = "label8";
            this.DOGRUCEVAP.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DOGRUCEVAP);
            this.Controls.Add(this.CEVAP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBLYANLIS);
            this.Controls.Add(this.LBLDOGRU);
            this.Controls.Add(this.LBLSORUNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNSONRAKI);
            this.Controls.Add(this.BTND);
            this.Controls.Add(this.BTNC);
            this.Controls.Add(this.BTNB);
            this.Controls.Add(this.BTNA);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Soru No:";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTNA;
        private System.Windows.Forms.Button BTNB;
        private System.Windows.Forms.Button BTNC;
        private System.Windows.Forms.Button BTND;
        private System.Windows.Forms.Button BTNSONRAKI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLSORUNO;
        private System.Windows.Forms.Label LBLDOGRU;
        private System.Windows.Forms.Label LBLYANLIS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CEVAP;
        private System.Windows.Forms.Label DOGRUCEVAP;
    }
}

