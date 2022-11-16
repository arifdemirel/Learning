namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lble = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.bareparti = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.bardparti = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.barcparti = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.barbparti = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.baraparti = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblparta = new System.Windows.Forms.Label();
            this.lblpartb = new System.Windows.Forms.Label();
            this.lblpartc = new System.Windows.Forms.Label();
            this.lblpartd = new System.Windows.Forms.Label();
            this.lblparte = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 28);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(618, 147);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblparte);
            this.groupBox2.Controls.Add(this.lblpartd);
            this.groupBox2.Controls.Add(this.lblpartc);
            this.groupBox2.Controls.Add(this.lblpartb);
            this.groupBox2.Controls.Add(this.lblparta);
            this.groupBox2.Controls.Add(this.lble);
            this.groupBox2.Controls.Add(this.lbld);
            this.groupBox2.Controls.Add(this.lblc);
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Controls.Add(this.bareparti);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bardparti);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.barcparti);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.barbparti);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.baraparti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ilçe Değerleri";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(421, 219);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(16, 13);
            this.lble.TabIndex = 17;
            this.lble.Text = "0:";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(421, 178);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(16, 13);
            this.lbld.TabIndex = 16;
            this.lbld.Text = "0:";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(421, 142);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(16, 13);
            this.lblc.TabIndex = 15;
            this.lblc.Text = "0:";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(421, 107);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(16, 13);
            this.lblb.TabIndex = 14;
            this.lblb.Text = "0:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(422, 71);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(16, 13);
            this.lbla.TabIndex = 13;
            this.lbla.Text = "0:";
            // 
            // bareparti
            // 
            this.bareparti.Location = new System.Drawing.Point(105, 219);
            this.bareparti.Maximum = 200;
            this.bareparti.Name = "bareparti";
            this.bareparti.Size = new System.Drawing.Size(273, 23);
            this.bareparti.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "E PARTİ:";
            // 
            // bardparti
            // 
            this.bardparti.Location = new System.Drawing.Point(105, 178);
            this.bardparti.Maximum = 200;
            this.bardparti.Name = "bardparti";
            this.bardparti.Size = new System.Drawing.Size(273, 23);
            this.bardparti.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "D PARTİ:";
            // 
            // barcparti
            // 
            this.barcparti.Location = new System.Drawing.Point(105, 142);
            this.barcparti.Maximum = 200;
            this.barcparti.Name = "barcparti";
            this.barcparti.Size = new System.Drawing.Size(273, 23);
            this.barcparti.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "C PARTİ:";
            // 
            // barbparti
            // 
            this.barbparti.Location = new System.Drawing.Point(105, 107);
            this.barbparti.Maximum = 200;
            this.barbparti.Name = "barbparti";
            this.barbparti.Size = new System.Drawing.Size(273, 23);
            this.barbparti.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "B PARTİ:";
            // 
            // baraparti
            // 
            this.baraparti.Location = new System.Drawing.Point(105, 71);
            this.baraparti.Maximum = 200;
            this.baraparti.Name = "baraparti";
            this.baraparti.Size = new System.Drawing.Size(273, 23);
            this.baraparti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE SEÇİN:";
            // 
            // lblparta
            // 
            this.lblparta.AutoSize = true;
            this.lblparta.Location = new System.Drawing.Point(477, 71);
            this.lblparta.Name = "lblparta";
            this.lblparta.Size = new System.Drawing.Size(16, 13);
            this.lblparta.TabIndex = 18;
            this.lblparta.Text = "0:";
            // 
            // lblpartb
            // 
            this.lblpartb.AutoSize = true;
            this.lblpartb.Location = new System.Drawing.Point(477, 107);
            this.lblpartb.Name = "lblpartb";
            this.lblpartb.Size = new System.Drawing.Size(16, 13);
            this.lblpartb.TabIndex = 19;
            this.lblpartb.Text = "0:";
            // 
            // lblpartc
            // 
            this.lblpartc.AutoSize = true;
            this.lblpartc.Location = new System.Drawing.Point(477, 142);
            this.lblpartc.Name = "lblpartc";
            this.lblpartc.Size = new System.Drawing.Size(16, 13);
            this.lblpartc.TabIndex = 20;
            this.lblpartc.Text = "0:";
            // 
            // lblpartd
            // 
            this.lblpartd.AutoSize = true;
            this.lblpartd.Location = new System.Drawing.Point(477, 178);
            this.lblpartd.Name = "lblpartd";
            this.lblpartd.Size = new System.Drawing.Size(16, 13);
            this.lblpartd.TabIndex = 21;
            this.lblpartd.Text = "0:";
            // 
            // lblparte
            // 
            this.lblparte.AutoSize = true;
            this.lblparte.Location = new System.Drawing.Point(477, 219);
            this.lblparte.Name = "lblparte";
            this.lblparte.Size = new System.Drawing.Size(16, 13);
            this.lblparte.TabIndex = 22;
            this.lblparte.Text = "0:";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.ProgressBar bareparti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar bardparti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar barcparti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar barbparti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar baraparti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblparte;
        private System.Windows.Forms.Label lblpartd;
        private System.Windows.Forms.Label lblpartc;
        private System.Windows.Forms.Label lblpartb;
        private System.Windows.Forms.Label lblparta;
    }
}