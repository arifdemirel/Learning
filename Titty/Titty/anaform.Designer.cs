namespace Titty
{
    partial class anaform
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
            this.btnkategori = new System.Windows.Forms.Button();
            this.btnurun = new System.Windows.Forms.Button();
            this.btnistatistikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(12, 12);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(161, 126);
            this.btnkategori.TabIndex = 0;
            this.btnkategori.Text = "KATEGORİ İŞLEMLERİ";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // btnurun
            // 
            this.btnurun.Location = new System.Drawing.Point(191, 12);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(161, 126);
            this.btnurun.TabIndex = 1;
            this.btnurun.Text = "ÜRÜN İŞLEMLERİ";
            this.btnurun.UseVisualStyleBackColor = true;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // btnistatistikler
            // 
            this.btnistatistikler.Location = new System.Drawing.Point(374, 12);
            this.btnistatistikler.Name = "btnistatistikler";
            this.btnistatistikler.Size = new System.Drawing.Size(161, 126);
            this.btnistatistikler.TabIndex = 2;
            this.btnistatistikler.Text = "İSTATİSTİKLER";
            this.btnistatistikler.UseVisualStyleBackColor = true;
            this.btnistatistikler.Click += new System.EventHandler(this.btnistatistikler_Click);
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 156);
            this.Controls.Add(this.btnistatistikler);
            this.Controls.Add(this.btnurun);
            this.Controls.Add(this.btnkategori);
            this.Name = "anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anaform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.Button btnistatistikler;
    }
}