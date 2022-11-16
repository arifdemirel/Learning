namespace Proje_Hastane
{
    partial class sekretergiris
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
            this.txtsifre.Location = new System.Drawing.Point(109, 81);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 18;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(109, 54);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(100, 20);
            this.msktc.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "T.C. KİMLİK NO:";
            // 
            // btnhastagirisyap
            // 
            this.btnhastagirisyap.Location = new System.Drawing.Point(123, 118);
            this.btnhastagirisyap.Name = "btnhastagirisyap";
            this.btnhastagirisyap.Size = new System.Drawing.Size(75, 23);
            this.btnhastagirisyap.TabIndex = 13;
            this.btnhastagirisyap.Text = "GİRİŞ YAP";
            this.btnhastagirisyap.UseVisualStyleBackColor = true;
            this.btnhastagirisyap.Click += new System.EventHandler(this.btnhastagirisyap_Click);
            // 
            // btnanapanel
            // 
            this.btnanapanel.Location = new System.Drawing.Point(229, 168);
            this.btnanapanel.Name = "btnanapanel";
            this.btnanapanel.Size = new System.Drawing.Size(96, 23);
            this.btnanapanel.TabIndex = 19;
            this.btnanapanel.Text = "Ana Panele Dön";
            this.btnanapanel.UseVisualStyleBackColor = true;
            this.btnanapanel.Click += new System.EventHandler(this.btnanapanel_Click);
            // 
            // sekretergiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnanapanel);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhastagirisyap);
            this.Name = "sekretergiris";
            this.Text = "sekretergiris";
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