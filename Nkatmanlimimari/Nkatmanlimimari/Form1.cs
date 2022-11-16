using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using layerEntity;
using veriAccessLayer;
using Nkatmanlimimari;
using LogicLayer;

namespace Nkatmanlimimari
{
    public partial class btnguncelle : Form
    {
        public btnguncelle()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<entityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
        }

        private void lblekle_Click(object sender, EventArgs e)
        {
            entityPersonel entekle = new entityPersonel();
            entekle.Ad = textBox2.Text;
            entekle.Soyad = textBox3.Text;
            entekle.Sehir = textBox5.Text;
            entekle.Maas = short.Parse(textBox6.Text);
            entekle.Gorev = textBox4.Text;

            LogicPersonel.LLPersonelEkle(entekle);
              
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            entityPersonel entsil = new entityPersonel();
            entsil.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(entsil.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entityPersonel entgunc = new entityPersonel();
            entgunc.Id = Convert.ToInt32(textBox1.Text);
            entgunc.Ad= textBox2.Text;
            entgunc.Soyad = textBox3.Text;
            entgunc.Gorev= textBox4.Text;
            entgunc.Sehir = textBox5.Text;
            entgunc.Maas = short.Parse(textBox6.Text);
            LogicPersonel.LLPersonelGuncelle(entgunc);
        }
    }
}
