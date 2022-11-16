namespace Proje_Hastane
{
    partial class frmhasta
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
            this.btnhastagirisyap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.lnkuyeol = new System.Windows.Forms.LinkLabel();
            this.btnanapanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhastagirisyap
            // 
            this.btnhastagirisyap.Location = new System.Drawing.Point(112, 110);
            this.btnhastagirisyap.Name = "btnhastagirisyap";
            this.btnhastagirisyap.Size = new System.Drawing.Size(75, 23);
            this.btnhastagirisyap.TabIndex = 0;
            this.btnhastagirisyap.Text = "GİRİŞ YAP";
            this.btnhastagirisyap.UseVisualStyleBackColor = true;
            this.btnhastagirisyap.Click += new System.EventHandler(this.btnhastagirisyap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. KİMLİK NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ŞİFRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "HASTA GİRİŞ PANELİ";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(112, 49);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(100, 20);
            this.msktc.TabIndex = 4;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(112, 81);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 5;
            this.txttc.UseSystemPasswordChar = true;
            // 
            // lnkuyeol
            // 
            this.lnkuyeol.AutoSize = true;
            this.lnkuyeol.Location = new System.Drawing.Point(220, 120);
            this.lnkuyeol.Name = "lnkuyeol";
            this.lnkuyeol.Size = new System.Drawing.Size(39, 13);
            this.lnkuyeol.TabIndex = 6;
            this.lnkuyeol.TabStop = true;
            this.lnkuyeol.Text = "Üye Ol";
            this.lnkuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkuyeol_LinkClicked);
            // 
            // btnanapanel
            // 
            this.btnanapanel.Location = new System.Drawing.Point(299, 165);
            this.btnanapanel.Name = "btnanapanel";
            this.btnanapanel.Size = new System.Drawing.Size(96, 23);
            this.btnanapanel.TabIndex = 7;
            this.btnanapanel.Text = "Ana Panele Dön";
            this.btnanapanel.UseVisualStyleBackColor = true;
            this.btnanapanel.Click += new System.EventHandler(this.btnanapanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmhasta
            // 
            this.AcceptButton = this.btnhastagirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnanapanel);
            this.Controls.Add(this.lnkuyeol);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhastagirisyap);
            this.Name = "frmhasta";
            this.Text = "HASTA GİRİŞ PANELİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirisyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.LinkLabel lnkuyeol;
        private System.Windows.Forms.Button btnanapanel;
        private System.Windows.Forms.Button button1;
    }
}