using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÜFE
{
    public partial class SU3 : Form
    {
        public SU3()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, su, bilet,toplam;
            misir = Convert.ToInt16(txt_misir.Text);
            cay = Convert.ToInt16(txt_CAY.Text);
            su = Convert.ToInt16(txt_SU.Text);
            bilet = Convert.ToInt16(txt_BILET.Text);
            toplam = (misir* 25) + (cay * 5) + (su * 4) + (bilet * 50);
            TOPLAMLBL.Text = toplam.ToString()+"TL";
            kasatutar = kasatutar + toplam;
            SONUC.Text = kasatutar.ToString() + "TL";
        

        }

        private void lbl_temizle_Click(object sender, EventArgs e)
        {
            txt_BILET.Text= "";
            txt_CAY.Text="";
            txt_misir.Text="";
            txt_SU.Text="";
            txt_misir.Focus();
            SONUC.Text = " 0.00 TL";
            TOPLAMLBL.Text = "0.00 TL";
   
        }

        private void SU3_Load(object sender, EventArgs e)
        {

        }

        private void MUSTERITOPLAM_Click(object sender, EventArgs e)
        {

        }
    }
}
