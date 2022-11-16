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
    public partial class ogretmen : Form
    {
        public ogretmen()
        {
            InitializeComponent();
            btnsinavnotlari.Enabled = false;

        }
        
        
            

        private void btnkulupislemleri_Click(object sender, EventArgs e)
            

        {
            kulup formkulup = new kulup();
            formkulup.Show();
        }

        private void btnsinavnotlari_Click(object sender, EventArgs e)
        {
            
            {

                btnsinavnotlari.Enabled = false;
                
                ogrencinotlar formogrenci = new ogrencinotlar();
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
    }
}
