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

namespace Proje_Hastane
{
    public partial class doktorpaneli : Form
    {
        public doktorpaneli()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        private void doktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_doktorlar", bgl._conn_());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl._conn_().Close();

            SqlCommand getbranches = new SqlCommand("SELECT bransAd FROM tlb_Branslar", bgl._conn_());
            SqlDataReader dr2 = getbranches.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl._conn_().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand adddoctor = new SqlCommand("INSERT INTO tbl_doktorlar (Doktorad,Doktorsoyad,Doktorbrans,Doktortc,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl._conn_());
            adddoctor.Parameters.AddWithValue("@d1", txtad.Text);
            adddoctor.Parameters.AddWithValue("@d2", txtsoyad.Text);
            adddoctor.Parameters.AddWithValue("@d3", cmbbrans.Text);
            adddoctor.Parameters.AddWithValue("@d4", msktc.Text);
            adddoctor.Parameters.AddWithValue("@d5", txtsifre.Text);
            adddoctor.ExecuteNonQuery();
            relist();
            bgl._conn_().Close();

            MessageBox.Show("Doktor Eklendi");
        }
        public void relist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_doktorlar", bgl._conn_());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl._conn_().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("UPDATE tbl_doktorlar SET Doktortc=@p1,Doktorad=@p2,Doktorsoyad=@p3,Doktorbrans=@p4,Doktorsifre=@p5 WHERE Doktortc=@p1 ", bgl._conn_());
            update.Parameters.AddWithValue("@p1", msktc.Text);
            update.Parameters.AddWithValue("@p2", txtad.Text);
            update.Parameters.AddWithValue("@p3", txtsoyad.Text);
            update.Parameters.AddWithValue("@p4", cmbbrans.Text);
            update.Parameters.AddWithValue("@p5", txtsifre.Text);
            update.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir, Şifreniz:" + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentvalue = dataGridView1.SelectedCells[0].RowIndex;

            msktc.Text = dataGridView1.Rows[currentvalue].Cells[4].Value.ToString();
            txtad.Text = dataGridView1.Rows[currentvalue].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[currentvalue].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[currentvalue].Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[currentvalue].Cells[5].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete from tbl_doktorlar where Doktortc=@d1", bgl._conn_());
            delete.Parameters.AddWithValue("@d1", msktc.Text);
            delete.ExecuteNonQuery();
            bgl._conn_().Close();
            relist();
            MessageBox.Show("Doktor Sistemden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
