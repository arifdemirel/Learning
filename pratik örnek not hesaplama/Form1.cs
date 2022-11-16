using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratik_örnek_not_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AD,SOYAD;
            int    SINAV1,SINAV2,PROJE;
            double ortalama;
            AD = textBox1.Text;
            SOYAD = textBox2.Text;
            SINAV1= Convert.ToInt16(textBox3.Text);
            SINAV2 = Convert.ToInt16(textBox4.Text);
            PROJE = Convert.ToInt16(textBox5.Text);
            ortalama = (SINAV1 + SINAV2 + PROJE) / 3;
            listBox1.Items.Add(AD+" "+SOYAD+" "+SINAV1+" "+SINAV2+" "+PROJE+" "+ortalama);
        }
    }
}
