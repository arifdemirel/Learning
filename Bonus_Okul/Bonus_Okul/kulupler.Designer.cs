namespace Bonus_Okul
{
    partial class kulupler
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
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblkuluplerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonus_okulDataSet = new Bonus_Okul.Bonus_okulDataSet();
            this.tbl_kuluplerTableAdapter = new Bonus_Okul.Bonus_okulDataSetTableAdapters.tbl_kuluplerTableAdapter();
            this.kULUPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kULUPAADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkuluplerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonus_okulDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(283, 49);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(136, 48);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(444, 49);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(136, 48);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(283, 112);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(136, 48);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(444, 112);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(136, 48);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULÜP İŞLEMLERİ PANELİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kULUPIDDataGridViewTextBoxColumn,
            this.kULUPAADDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblkuluplerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 401);
            this.dataGridView1.TabIndex = 5;
            // 
            // tblkuluplerBindingSource
            // 
            this.tblkuluplerBindingSource.DataMember = "tbl_kulupler";
            this.tblkuluplerBindingSource.DataSource = this.bonus_okulDataSet;
            // 
            // bonus_okulDataSet
            // 
            this.bonus_okulDataSet.DataSetName = "Bonus_okulDataSet";
            this.bonus_okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_kuluplerTableAdapter
            // 
            this.tbl_kuluplerTableAdapter.ClearBeforeFill = true;
            // 
            // kULUPIDDataGridViewTextBoxColumn
            // 
            this.kULUPIDDataGridViewTextBoxColumn.DataPropertyName = "KULUPID";
            this.kULUPIDDataGridViewTextBoxColumn.HeaderText = "KULUPID";
            this.kULUPIDDataGridViewTextBoxColumn.Name = "kULUPIDDataGridViewTextBoxColumn";
            // 
            // kULUPAADDataGridViewTextBoxColumn
            // 
            this.kULUPAADDataGridViewTextBoxColumn.DataPropertyName = "KULUPAAD";
            this.kULUPAADDataGridViewTextBoxColumn.HeaderText = "KULUPAAD";
            this.kULUPAADDataGridViewTextBoxColumn.Name = "kULUPAADDataGridViewTextBoxColumn";
            // 
            // kulupler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnlistele);
            this.Name = "kulupler";
            this.Text = "LİSTELE";
            this.Load += new System.EventHandler(this.kulupler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkuluplerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonus_okulDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bonus_okulDataSet bonus_okulDataSet;
        private System.Windows.Forms.BindingSource tblkuluplerBindingSource;
        private Bonus_okulDataSetTableAdapters.tbl_kuluplerTableAdapter tbl_kuluplerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kULUPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kULUPAADDataGridViewTextBoxColumn;
    }
}