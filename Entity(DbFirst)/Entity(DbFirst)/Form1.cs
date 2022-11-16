using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Entity_DbFirst_
{
    public partial class Form1 : Form
    {
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        public Form1()
        {
            InitializeComponent();
            radioButton5.Enabled = false;
        }

        private void btnderslistele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.tbl_dersler.ToList();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

            OgrenciRelist();
            //istenmeyen sütunları gizlemek için kullanılabilir
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnnotlistele_Click(object sender, EventArgs e)
        {                   //item yerine istediğimiz ismi verebiliriz
            var query = from item in db.tbl_notlar
                        select new
                        {
                            item.NOTID,
                            //item.OGR,  tablo birleştirmek için kodu aşağıdaki gibi yazarız
                            item.tbl_ogrenciler.AD,
                            item.tbl_ogrenciler.SOYAD,
                            item.tbl_dersler.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            // ogrenci id yerine diğer ilişkili tabloda yer alan öğrenci adının gelmesi için
            // sql de prosedür yazacağız
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource = db.tbl_notlar.ToList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            tbl_ogrenciler yeniOgr = new tbl_ogrenciler();
            yeniOgr.AD = txtad.Text;
            yeniOgr.SOYAD = txtsoyad.Text;
            db.tbl_ogrenciler.Add(yeniOgr);
            db.SaveChanges();
            OgrenciRelist();



        }

        void OgrenciRelist()
        {
            dataGridView1.DataSource = db.tbl_ogrenciler.ToList();
        }
        void DersRelist()
        {
            dataGridView1.DataSource = db.tbl_dersler.ToList();
        }

        private void btndersekle_Click(object sender, EventArgs e)
        {
            tbl_dersler yeniDers = new tbl_dersler();
            yeniDers.DERSAD = txtdersad.Text;
            db.tbl_dersler.Add(yeniDers);
            db.SaveChanges();
            DersRelist();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrenciid.Text);
            var idX = db.tbl_ogrenciler.Find(id);
            db.tbl_ogrenciler.Remove(idX);
            db.SaveChanges();
            OgrenciRelist();
            MessageBox.Show("Öğrenci Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrenciid.Text);
            var idx = db.tbl_ogrenciler.Find(id);
            idx.AD = txtad.Text;
            idx.SOYAD = txtsoyad.Text;
            idx.FOTOGRAF = txtfoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi");
            OgrenciRelist();
        }

        private void btnprocedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            //x yerine istediğim değeri verebilirim  // entity sorgusunda  yazarken bir tane & veya | simgesi koyulur
            dataGridView1.DataSource = db.tbl_ogrenciler.Where(x => x.AD == txtad.Text | x.SOYAD == txtsoyad.Text | x.ID.ToString() == txtogrenciid.Text).ToList();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            string _aranan = txtad.Text;
            var degerler = from item in db.tbl_ogrenciler
                           where item.AD.Contains(_aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btnlinq_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                List<tbl_ogrenciler> liste1 = db.tbl_ogrenciler.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked == true)
            {
                List<tbl_ogrenciler> liste2 = db.tbl_ogrenciler.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked == true)
            {
                // Take komutu verilen sayı kadar girdiyi baştan sayarak gösterir.
                List<tbl_ogrenciler> liste3 = db.tbl_ogrenciler.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;

            }
            if (radioButton4.Checked == true)
            {
                List<tbl_ogrenciler> liste4 = db.tbl_ogrenciler.Where(p => p.ID.ToString() == txtogrenciid.Text).ToList();
                dataGridView1.DataSource = liste4;
            }

            if (radioButton5.Checked == true)
            {
                List<tbl_ogrenciler> liste5 = db.tbl_ogrenciler.Where(p => p.AD.StartsWith(txtbasharf.Text.ToString())).ToList();
                dataGridView1.DataSource = liste5;

            }

            if (radioButton6.Checked == true)
            {
                List<tbl_ogrenciler> liste6 = db.tbl_ogrenciler.Where(p => p.AD.EndsWith(txtsonharf.Text.ToString())).ToList();
                dataGridView1.DataSource = liste6;

            }
            if (radioButton7.Checked == true)
            {
                bool deger = db.tbl_kulupler.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton8.Checked == true)
            {
                int toplam = db.tbl_ogrenciler.Count();
                MessageBox.Show(toplam.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton9.Checked == true)
            {
                var toplam = db.tbl_notlar.Sum(p => p.SINAV1);
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı:" + toplam.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton10.Checked == true)
            {
                var ortalama = db.tbl_notlar.Average(p => p.SINAV1);
                MessageBox.Show(ortalama.ToString(), "Ortalama Not:" + ortalama.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton11.Checked == true)
            {
                var enyuksek = db.tbl_notlar.Max(p => p.SINAV1);
                MessageBox.Show(enyuksek.ToString(), "Ortalama Not:" + enyuksek.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton12.Checked == true)
            {
                var _endusuk = db.tbl_notlar.Min(p => p.SINAV1);
                MessageBox.Show(_endusuk.ToString(), "Ortalama Not:" + _endusuk.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton13.Checked == true)
            {
                var _enbasarili = db.tbl_notlar.Max(p => p.SINAV1);
                var deger = db.tbl_notlar.Where(p => p.SINAV1 == _enbasarili).ToList();
                dataGridView1.DataSource = deger;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbasharf_TextChanged(object sender, EventArgs e)
        {
            if (txtbasharf.Text.Length > 0)
            {
                radioButton5.Enabled = true;
            }
        }

        private void btnjoin_Click(object sender, EventArgs e)
        {
            //tablo birleştirme
            var sorgu = from d1 in db.tbl_notlar
                        // "on" komutu join işleminden sonra gelir. sonraki join bunu takip eder.
                        join d2 in db.tbl_ogrenciler
                         on d1.OGR equals d2.ID
                        join d3 in db.tbl_dersler
                        on d1.DERS equals d3.DERSID
                       
                        select new
                        {
                        // bunlar sütun ismi olarak kullanılır ve TÜRKÇE karakter kabul eder. 
                            ÖĞRENCİ = d2.AD,
                            SOYAD = d2.SOYAD,
                        // 2 değeri tek sütuna yazdırabilmek için:   ÖĞRENCİ=d2.AD + " " + d2.SOYAD,
                            DERS = d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2 = d1.SINAV2,
                            SINAV3 = d1.SINAV3,
                            ORTALAMA = d1.ORTALAMA,
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
