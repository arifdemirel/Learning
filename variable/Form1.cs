using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = "Merhaba bugün 11 Ekim 2017 Çarşamba";
            label1.Text = metin;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adSoyad, meslek;
            adSoyad= "Eylül Yücedağ";
            meslek = "Öğretmen";
            label2.Text = adSoyad;
            label3.Text = meslek;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string şehir;
            şehir = textBox1.Text;
            label4.Text = şehir;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string adsoyad;
            string yaş;
            string meslek;
            string cinsiyet;
            adsoyad = textBox2.Text;
            yaş = maskedTextBox1.Text;
            meslek = textBox3.Text;
            cinsiyet= textBox4.Text;
            


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add (textBox2.Text+" " + maskedTextBox1.Text + " " + textBox3.Text + " " + textBox4.Text);
        }
    }
}
