using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_değişkenler_Pratik_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, carpim, fark, bolum;
            sayi1 = Convert.ToInt64(textBox1.Text);
            sayi2 = Convert.ToInt64(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            fark= sayi1 - sayi2;
            MessageBox.Show("Toplam:" + toplam + "\n" + "Fark:" + fark + "\n" + "Çarpım:" + carpim + "\n" + "Bölüm:" + bolum);
            
            
        }
    }
}
