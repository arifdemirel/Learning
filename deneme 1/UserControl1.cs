using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_1
{
    public partial class AraçKullanımları: UserControl
    {
        public AraçKullanımları()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Fuck This World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Emrah";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text="Emrah";
            label7.Text="Kavak";
            label8.Text = "Bilgisayar Mühendisi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text="Emrahnatör2064";
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text= textBox2.Text;
            label11.Text= textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}
