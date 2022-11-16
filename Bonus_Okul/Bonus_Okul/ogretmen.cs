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
    public partial class ogretmen : Form
    {
        public ogretmen()
        {
            InitializeComponent();
            btnsinavnotlari.Enabled = false;
        }
        private void btnkulupislemleri_Click(object sender, EventArgs e)


        {
            kulupler formkulup = new kulupler();
            formkulup.Show();
        }

        private void btnsinavnotlari_Click(object sender, EventArgs e)
        {

            {

                btnsinavnotlari.Enabled = false;

                ogrenci formogrenci = new ogrenci();
                formogrenci.number = ogrid2.Text;
                formogrenci.Show();
                ogrid2.Text = "";


            }
        }

        private void btnogretmenler_Click(object sender, EventArgs e)
        {
            ogretmen ogretmen = new ogretmen();
            ogretmen.Show();

        }

        private void button1_Click(object sender, EventArgs e)

        {

            btnsinavnotlari.Enabled = true;
        }

        private void ogretmen_Load(object sender, EventArgs e)
        {
            

        }
    }
}
