using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonus_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ogrencinotlar formogrenci = new ogrencinotlar();
            formogrenci.number = textBox1.Text;
            formogrenci.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogretmen formogretmen = new ogretmen();
           formogretmen.Show();
        }
    }
}
