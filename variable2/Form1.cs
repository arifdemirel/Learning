using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variable2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TC, adsoyad, meslek, cinsiyet, yaş;
            TC = maskedTextBox1.Text;
            adsoyad = textBox1.Text;
            meslek = textBox2.Text;
            cinsiyet = textBox3.Text;
            yaş=maskedTextBox2.Text;
            listBox1.Items.Add(TC + " " + adsoyad + " " + meslek + " " + cinsiyet + " " + yaş);
  
        }
    }
}
