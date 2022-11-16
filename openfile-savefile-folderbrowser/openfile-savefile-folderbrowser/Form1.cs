using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace openfile_savefile_folderbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaadi, dosyayolu;
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog2.FileName);
                string satir = sr.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }
                    }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "Text Documents |* .txt";
            saveFileDialog2.Title = "Metin Belgesi";
            saveFileDialog2.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog2.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("dosya kaydedildi");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pdfokutma pdfokutma = new pdfokutma();
            pdfokutma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog2.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }
        }
    }
}
