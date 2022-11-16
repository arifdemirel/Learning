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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
            relist();
        }
        DBENTITYURUNEntities db = new DBENTITYURUNEntities();
        void relist()
        {
            var kategoriler = db.tbl_kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }
       
        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_kategori t = new tbl_kategori();
            t.Kategori = txtad.Text;
            db.tbl_kategori.Add(t);
            db.SaveChanges();
            relist();
            MessageBox.Show("Kategori Eklendi");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = db.tbl_kategori.Find(x);
            db.tbl_kategori.Remove(ktgr);
            db.SaveChanges();
            relist();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = db.tbl_kategori.Find(x);
            ktgr.Kategori = txtad.Text;
            db.SaveChanges();
            relist();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaform gurcan = new anaform();
            gurcan.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentvalue = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[currentvalue].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[currentvalue].Cells[1].Value.ToString();
        }
    }
}
