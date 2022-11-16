namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            this.ogreklegbx = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblkalansayisi = new System.Windows.Forms.Label();
            this.lblgecensayisi = new System.Windows.Forms.Label();
            this.lblsinifortalama = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbNotKayitDataSet = new Not_Kayıt_Sistemi.DbNotKayitDataSet();
            this.tblmatematikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_matematikTableAdapter = new Not_Kayıt_Sistemi.DbNotKayitDataSetTableAdapters.tbl_matematikTableAdapter();
            this.dbNotKayitDataSet1 = new Not_Kayıt_Sistemi.DbNotKayitDataSet1();
            this.tblmatematikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_matematikTableAdapter1 = new Not_Kayıt_Sistemi.DbNotKayitDataSet1TableAdapters.tbl_matematikTableAdapter();
            this.dbNotKayitDataSet2 = new Not_Kayıt_Sistemi.DbNotKayitDataSet2();
            this.tblmatematikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_matematikTableAdapter2 = new Not_Kayıt_Sistemi.DbNotKayitDataSet2TableAdapters.tbl_matematikTableAdapter();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ogreklegbx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmatematikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmatematikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmatematikBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ogreklegbx
            // 
            this.ogreklegbx.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ogreklegbx.Controls.Add(this.button1);
            this.ogreklegbx.Controls.Add(this.TxtSoyad);
            this.ogreklegbx.Controls.Add(this.label3);
            this.ogreklegbx.Controls.Add(this.TxtAd);
            this.ogreklegbx.Controls.Add(this.MskNumber);
            this.ogreklegbx.Controls.Add(this.label2);
            this.ogreklegbx.Controls.Add(this.label1);
            this.ogreklegbx.Location = new System.Drawing.Point(12, 12);
            this.ogreklegbx.Name = "ogreklegbx";
            this.ogreklegbx.Size = new System.Drawing.Size(275, 276);
            this.ogreklegbx.TabIndex = 0;
            this.ogreklegbx.TabStop = false;
            this.ogreklegbx.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrenciyi kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(113, 126);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 27);
            this.TxtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(113, 88);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 27);
            this.TxtAd.TabIndex = 3;
            // 
            // MskNumber
            // 
            this.MskNumber.Location = new System.Drawing.Point(113, 49);
            this.MskNumber.Mask = "0000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(100, 27);
            this.MskNumber.TabIndex = 2;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.TxtSinav1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.TxtSinav3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSinav2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Girişi";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(113, 46);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(100, 27);
            this.TxtSinav1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "Notu Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(113, 126);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(100, 27);
            this.TxtSinav3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınav 3:";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(113, 88);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(100, 27);
            this.TxtSinav2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sınav 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.lblkalansayisi);
            this.groupBox2.Controls.Add(this.lblgecensayisi);
            this.groupBox2.Controls.Add(this.lblsinifortalama);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(575, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 276);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Girişi";
            // 
            // lblkalansayisi
            // 
            this.lblkalansayisi.AutoSize = true;
            this.lblkalansayisi.Location = new System.Drawing.Point(158, 106);
            this.lblkalansayisi.Name = "lblkalansayisi";
            this.lblkalansayisi.Size = new System.Drawing.Size(27, 19);
            this.lblkalansayisi.TabIndex = 10;
            this.lblkalansayisi.Text = "00";
            // 
            // lblgecensayisi
            // 
            this.lblgecensayisi.AutoSize = true;
            this.lblgecensayisi.Location = new System.Drawing.Point(158, 69);
            this.lblgecensayisi.Name = "lblgecensayisi";
            this.lblgecensayisi.Size = new System.Drawing.Size(27, 19);
            this.lblgecensayisi.TabIndex = 9;
            this.lblgecensayisi.Text = "00";
            // 
            // lblsinifortalama
            // 
            this.lblsinifortalama.AutoSize = true;
            this.lblsinifortalama.Location = new System.Drawing.Point(158, 34);
            this.lblsinifortalama.Name = "lblsinifortalama";
            this.lblsinifortalama.Size = new System.Drawing.Size(27, 19);
            this.lblsinifortalama.TabIndex = 8;
            this.lblsinifortalama.Text = "00";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 61);
            this.button3.TabIndex = 6;
            this.button3.Text = "Notu Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(3, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1008, 351);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNODataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblmatematikBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmatematikBindingSource
            // 
            this.tblmatematikBindingSource.DataMember = "tbl_matematik";
            this.tblmatematikBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // tbl_matematikTableAdapter
            // 
            this.tbl_matematikTableAdapter.ClearBeforeFill = true;
            // 
            // dbNotKayitDataSet1
            // 
            this.dbNotKayitDataSet1.DataSetName = "DbNotKayitDataSet1";
            this.dbNotKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmatematikBindingSource1
            // 
            this.tblmatematikBindingSource1.DataMember = "tbl_matematik";
            this.tblmatematikBindingSource1.DataSource = this.dbNotKayitDataSet1;
            // 
            // tbl_matematikTableAdapter1
            // 
            this.tbl_matematikTableAdapter1.ClearBeforeFill = true;
            // 
            // dbNotKayitDataSet2
            // 
            this.dbNotKayitDataSet2.DataSetName = "DbNotKayitDataSet2";
            this.dbNotKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmatematikBindingSource2
            // 
            this.tblmatematikBindingSource2.DataMember = "tbl_matematik";
            this.tblmatematikBindingSource2.DataSource = this.dbNotKayitDataSet2;
            // 
            // tbl_matematikTableAdapter2
            // 
            this.tbl_matematikTableAdapter2.ClearBeforeFill = true;
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNODataGridViewTextBoxColumn
            // 
            this.oGRNODataGridViewTextBoxColumn.DataPropertyName = "OGRNO";
            this.oGRNODataGridViewTextBoxColumn.HeaderText = "OGRNO";
            this.oGRNODataGridViewTextBoxColumn.Name = "oGRNODataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ogreklegbx);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgretmenDetay";
            this.Text = "frmogretmendetay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.ogreklegbx.ResumeLayout(false);
            this.ogreklegbx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmatematikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmatematikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmatematikBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ogreklegbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblkalansayisi;
        private System.Windows.Forms.Label lblgecensayisi;
        private System.Windows.Forms.Label lblsinifortalama;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Not_Kayıt_Sistemi.DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tblmatematikBindingSource;
        private Not_Kayıt_Sistemi.DbNotKayitDataSetTableAdapters.tbl_matematikTableAdapter tbl_matematikTableAdapter;
        private Not_Kayıt_Sistemi.DbNotKayitDataSet1 dbNotKayitDataSet1;
        private System.Windows.Forms.BindingSource tblmatematikBindingSource1;
        private Not_Kayıt_Sistemi.DbNotKayitDataSet1TableAdapters.tbl_matematikTableAdapter tbl_matematikTableAdapter1;
        private Not_Kayıt_Sistemi.DbNotKayitDataSet2 dbNotKayitDataSet2;
        private System.Windows.Forms.BindingSource tblmatematikBindingSource2;
        private Not_Kayıt_Sistemi.DbNotKayitDataSet2TableAdapters.tbl_matematikTableAdapter tbl_matematikTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
    }
}