using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titty
{
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
            txtid.Enabled = false;
            relist();
        }
        DBENTITYURUNEntities db = new DBENTITYURUNEntities();
        void relist()
        {
            //dataGridView1.DataSource = db.tbl_urun.ToList(); bu herşeyi getiriyor, ham data dahik

            //sıradaki kod ise diagramdan bağladığımız ad üzerinden id nin kategori adını çekip datagridview da onu yazmasını sağlıyor ve ham veri göstermiyor.
            dataGridView1.DataSource = (from x in db.tbl_urun
                                        select new
                                        {
                                            x.URUN_ID,
                                            x.URUN_AD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.tbl_kategori.Kategori,
                                            x.DURUM
                                        }).ToList();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_urun u = new tbl_urun();
            u.URUN_AD = txturunad.Text;
            u.MARKA = txtmarka.Text;
            u.STOK = short.Parse(txtstok.Text);
            u.KATEGORI = int.Parse(cmbkategori.SelectedValue.ToString());
            u.FIYAT = decimal.Parse(txtfiyat.Text);
            u.DURUM = bool.Parse(txtdurum.Text);
            db.tbl_urun.Add(u);
            db.SaveChanges();
            relist();
            MessageBox.Show("Ürün Sisteme Kaydedildi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var u = db.tbl_urun.Find(x);
            u.URUN_AD = txturunad.Text;
            u.MARKA = txtmarka.Text;
            u.STOK = short.Parse(txtstok.Text);
            u.KATEGORI = int.Parse(cmbkategori.SelectedValue.ToString());
            u.FIYAT = decimal.Parse(txtfiyat.Text);
            db.SaveChanges();
            relist();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var u = db.tbl_urun.Find(x);
            db.tbl_urun.Remove(u);
            db.SaveChanges();
            relist();
            MessageBox.Show("Ürün Sistemden Kaldırıldı");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txturunad.Text = "";
            txtmarka.Text = "";
            txtfiyat.Text = "";
            txtdurum.Text = "";
            txtstok.Text = "";
            cmbkategori.Text = "";
        }

        private void urun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.tbl_kategori
                               select new
                               {
                                   x.ID,
                                   x.Kategori
                               }
                               ).ToList();
            cmbkategori.ValueMember = "ID";
            cmbkategori.DisplayMember = "Kategori";
            cmbkategori.DataSource = kategoriler;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            int currentvalue = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[currentvalue].Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.Rows[currentvalue].Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[currentvalue].Cells[2].Value.ToString();
            txtstok.Text = dataGridView1.Rows[currentvalue].Cells[3].Value.ToString();
            txtfiyat.Text = dataGridView1.Rows[currentvalue].Cells[4].Value.ToString();
            //txtdurum.Text = dataGridView1.Rows[currentvalue].Cells[6].Value.ToString();
            cmbkategori.Text = dataGridView1.Rows[currentvalue].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaform gurcan = new anaform();
            gurcan.Show();
        }

        /*
         dataGridView1.DataSource = (from x in db.tbl_urun 
                          select new
                        {
                            x.urunid,
                            x.urunad,
                            x.tbl_kategori.ad
                        }
                            ).ToList();
        */

    }
}
