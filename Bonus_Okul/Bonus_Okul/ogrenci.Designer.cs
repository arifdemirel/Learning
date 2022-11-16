namespace Bonus_Okul
{
    partial class ogrenci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblnotlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonusokulDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonus_okulDataSet = new Bonus_Okul.Bonus_okulDataSet();
            this.tbl_notlarTableAdapter = new Bonus_Okul.Bonus_okulDataSetTableAdapters.tbl_notlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnotlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusokulDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonus_okulDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblnotlarBindingSource
            // 
            this.tblnotlarBindingSource.DataMember = "tbl_notlar";
            this.tblnotlarBindingSource.DataSource = this.bonusokulDataSetBindingSource;
            // 
            // bonusokulDataSetBindingSource
            // 
            this.bonusokulDataSetBindingSource.DataSource = this.bonus_okulDataSet;
            this.bonusokulDataSetBindingSource.Position = 0;
            // 
            // bonus_okulDataSet
            // 
            this.bonus_okulDataSet.DataSetName = "Bonus_okulDataSet";
            this.bonus_okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_notlarTableAdapter
            // 
            this.tbl_notlarTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrenci";
            this.Text = "ogrenci";
            this.Load += new System.EventHandler(this.ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnotlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusokulDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonus_okulDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bonusokulDataSetBindingSource;
        private Bonus_okulDataSet bonus_okulDataSet;
        private System.Windows.Forms.BindingSource tblnotlarBindingSource;
        private Bonus_okulDataSetTableAdapters.tbl_notlarTableAdapter tbl_notlarTableAdapter;
    }
}