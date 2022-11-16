using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonus_Okul
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnogrenci_Click(object sender, EventArgs e)
        {
            ogrenci formogrenci = new ogrenci();
            formogrenci.number = textBox1.Text;
            formogrenci.Show();
            this.Hide();
        }

        private void btnogretmen_Click(object sender, EventArgs e)
        {
            ogretmen formogretmen = new ogretmen();
            formogretmen.Show();
        }
    }
}
