namespace Proje_Hastane
{
    partial class branspaneli
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
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbransid = new System.Windows.Forms.TextBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.txtbransad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sekretertc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsekreterad = new System.Windows.Forms.Label();
            this.lblsekretersoyad = new System.Windows.Forms.Label();
            this.sekreterpanelinedon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(109, 311);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(100, 28);
            this.btnguncelle.TabIndex = 35;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(181, 275);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 28);
            this.btnsil.TabIndex = 34;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(28, 275);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 28);
            this.btnekle.TabIndex = 33;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(381, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(655, 238);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbransid
            // 
            this.txtbransid.Location = new System.Drawing.Point(109, 200);
            this.txtbransid.Margin = new System.Windows.Forms.Padding(4);
            this.txtbransid.Name = "txtbransid";
            this.txtbransid.Size = new System.Drawing.Size(160, 22);
            this.txtbransid.TabIndex = 31;
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(109, 242);
            this.cmbbrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(160, 24);
            this.cmbbrans.TabIndex = 30;
            // 
            // txtbransad
            // 
            this.txtbransad.Location = new System.Drawing.Point(109, 153);
            this.txtbransad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbransad.Name = "txtbransad";
            this.txtbransad.Size = new System.Drawing.Size(160, 22);
            this.txtbransad.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Branş Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Branş ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sekreter TC:";
            // 
            // sekretertc
            // 
            this.sekretertc.Enabled = false;
            this.sekretertc.Location = new System.Drawing.Point(109, 51);
            this.sekretertc.Name = "sekretertc";
            this.sekretertc.Size = new System.Drawing.Size(160, 22);
            this.sekretertc.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sekreter Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sekreter Soyad:";
            // 
            // lblsekreterad
            // 
            this.lblsekreterad.AutoSize = true;
            this.lblsekreterad.Location = new System.Drawing.Point(109, 84);
            this.lblsekreterad.Name = "lblsekreterad";
            this.lblsekreterad.Size = new System.Drawing.Size(46, 16);
            this.lblsekreterad.TabIndex = 40;
            this.lblsekreterad.Text = "             ";
            // 
            // lblsekretersoyad
            // 
            this.lblsekretersoyad.AutoSize = true;
            this.lblsekretersoyad.Location = new System.Drawing.Point(109, 116);
            this.lblsekretersoyad.Name = "lblsekretersoyad";
            this.lblsekretersoyad.Size = new System.Drawing.Size(28, 16);
            this.lblsekretersoyad.TabIndex = 41;
            this.lblsekretersoyad.Text = "       ";
            // 
            // sekreterpanelinedon
            // 
            this.sekreterpanelinedon.Location = new System.Drawing.Point(112, 363);
            this.sekreterpanelinedon.Name = "sekreterpanelinedon";
            this.sekreterpanelinedon.Size = new System.Drawing.Size(122, 60);
            this.sekreterpanelinedon.TabIndex = 42;
            this.sekreterpanelinedon.Text = "Sekreter Paneline Dön";
            this.sekreterpanelinedon.UseVisualStyleBackColor = true;
            this.sekreterpanelinedon.Click += new System.EventHandler(this.button1_Click);
            // 
            // branspaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.sekreterpanelinedon);
            this.Controls.Add(this.lblsekretersoyad);
            this.Controls.Add(this.lblsekreterad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sekretertc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbransid);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txtbransad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "branspaneli";
            this.Text = "branspaneli";
            this.Load += new System.EventHandler(this.branspaneli_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbransid;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.TextBox txtbransad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sekretertc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsekreterad;
        private System.Windows.Forms.Label lblsekretersoyad;
        private System.Windows.Forms.Button sekreterpanelinedon;
    }
}