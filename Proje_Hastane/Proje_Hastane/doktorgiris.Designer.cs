namespace Proje_Hastane
{
    partial class doktorgiris
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
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhastagirisyap = new System.Windows.Forms.Button();
            this.btnanapanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(145, 103);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(132, 22);
            this.txtsifre.TabIndex = 12;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(145, 65);
            this.msktc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(132, 22);
            this.msktc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C. KİMLİK NO:";
            // 
            // btnhastagirisyap
            // 
            this.btnhastagirisyap.Location = new System.Drawing.Point(145, 135);
            this.btnhastagirisyap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhastagirisyap.Name = "btnhastagirisyap";
            this.btnhastagirisyap.Size = new System.Drawing.Size(100, 28);
            this.btnhastagirisyap.TabIndex = 7;
            this.btnhastagirisyap.Text = "GİRİŞ YAP";
            this.btnhastagirisyap.UseVisualStyleBackColor = true;
            this.btnhastagirisyap.Click += new System.EventHandler(this.btnhastagirisyap_Click);
            // 
            // btnanapanel
            // 
            this.btnanapanel.Location = new System.Drawing.Point(333, 190);
            this.btnanapanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnanapanel.Name = "btnanapanel";
            this.btnanapanel.Size = new System.Drawing.Size(141, 38);
            this.btnanapanel.TabIndex = 13;
            this.btnanapanel.Text = "Ana Panele Dön";
            this.btnanapanel.UseVisualStyleBackColor = true;
            this.btnanapanel.Click += new System.EventHandler(this.btnanapanel_Click);
            // 
            // doktorgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnanapanel);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhastagirisyap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "doktorgiris";
            this.Text = "doktorgiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhastagirisyap;
        private System.Windows.Forms.Button btnanapanel;
    }
}