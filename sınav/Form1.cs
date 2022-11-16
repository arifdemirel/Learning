using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad,TC;
            int vize1, vize2, vize3, final,ortalama;
            vize1 = Convert.ToInt16(textBox1.Text);
            vize2 = Convert.ToInt16(textBox5.Text);
            vize3 = Convert.ToInt16(textBox4.Text);
            final = Convert.ToInt16(textBox3.Text);
            ortalama = Convert.ToInt16(vize1*0.2 + vize2*0.2 + vize3  *0.2 + final * 0.4);
            ad = textBox6.Text;
            soyad= textBox7.Text;
            TC = Convert.ToString(textBox8.Text);

            label1.Text = vize1.ToString();
            label2.Text = vize2.ToString();
            label3.Text = vize3.ToString();
            label4.Text = final.ToString();
            label5.Text = ortalama.ToString();
            label6.Text= ad;
            label7.Text = soyad;
            label8.Text = TC;
            listBox1.Items.Add(vize1 + " " + vize2 + " " + vize3 + " " + final + " " + ortalama + " " + ad + " " + soyad + " " + TC);
        }
    }
}
