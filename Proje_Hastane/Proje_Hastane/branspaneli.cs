using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class branspaneli : Form
    {
        public branspaneli()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        public string tcsekreter;

        private void branspaneli_Load(object sender, EventArgs e)
        {
            SqlCommand writebranches = new SqlCommand("SELECT bransAd FROM tlb_Branslar", bgl._conn_());
            SqlDataReader dr2 = writebranches.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl._conn_().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tlb_Branslar", bgl._conn_());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl._conn_().Close();

            sekretertc.Text = tcsekreter;

            SqlCommand command = new SqlCommand("SELECT  sekreterad,sekretersoyad From Sekreter where sekretertc=@p1", bgl._conn_());
            command.Parameters.AddWithValue("@p1", sekretertc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblsekreterad.Text = dr[0] + "";
                lblsekretersoyad.Text = dr[1] + "";
            }
            bgl._conn_().Close();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand addbranch = new SqlCommand("INSERT INTO tlb_Branslar (bransad) values (@p1)", bgl._conn_());
            addbranch.Parameters.AddWithValue("@p1", txtbransad.Text);
            addbranch.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Branş Eklendi");
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand removebranch = new SqlCommand("delete from tlb_Branslar where bransid=@b1", bgl._conn_());
            removebranch.Parameters.AddWithValue("b1", txtbransid.Text);
            removebranch.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Branş Kaldırıldı");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand updatebranch = new SqlCommand("UPDATE tlb_Branslar set bransad=@b1 WHERE bransid=@b2",bgl._conn_());
            updatebranch.Parameters.AddWithValue("@b1", txtbransad.Text);
            updatebranch.Parameters.AddWithValue("@b2", txtbransid.Text);
            updatebranch.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Branş İsmi Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sekreterdetay sd = new sekreterdetay();
            sd.sekretertc = sekretertc.Text;
            sd.Show();
            Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentvalue = dataGridView1.SelectedCells[0].RowIndex;
            txtbransad.Text = dataGridView1.Rows[currentvalue].Cells[1].Value.ToString();
            txtbransid.Text = dataGridView1.Rows[currentvalue].Cells[0].Value.ToString();
            
        }
    }
}
