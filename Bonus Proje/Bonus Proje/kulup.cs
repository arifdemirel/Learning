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

namespace Bonus_Proje
{
    public partial class kulup : Form
    {
        public kulup()  
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-KVIRVD3;Initial Catalog=Bonus_okul;Integrated Security=True");

        void relist()
        {

            this.tbl_kuluplerTableAdapter.Fill(this.bonus_OkulDataSet.tbl_kulupler);

        }
        private void kulup_Shown(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_kulupler", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void kulup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bonus_OkulDataSet.tbl_kulupler' table. You can move, or remove it, as needed.
            this.tbl_kuluplerTableAdapter.Fill(this.bonus_OkulDataSet.tbl_kulupler);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            relist();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand update = new SqlCommand("UPDATE tbl_kulupler set kulupaad=@p1 WHERE KULUPID=@p2", _conn);
            update.Parameters.AddWithValue("@p1", txtkulupad.Text);
            update.Parameters.AddWithValue("@p2", txtkulupid.Text);
            update.ExecuteNonQuery();
            relist();
            MessageBox.Show("Kayıt Güncellendi");
            _conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentvalue = dataGridView1.SelectedCells[0].RowIndex;

            txtkulupid.Text = dataGridView1.Rows[currentvalue].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[currentvalue].Cells[1].Value.ToString();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand add = new SqlCommand("insert into tbl_kulupler (KULUPAAD,KULUPID) VALUES (@p1,@p2)", _conn);
            add.Parameters.AddWithValue("@p2", txtkulupid.Text);
            add.Parameters.AddWithValue("@p1", txtkulupad.Text);

            add.ExecuteNonQuery();
            relist();
            MessageBox.Show("Kayıt Eklendi");
            _conn.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand delete = new SqlCommand("delete from tbl_kulupler where KULUPID=@K9", _conn);
            delete.Parameters.AddWithValue("@k9", txtkulupid.Text);
            delete.ExecuteNonQuery();
            _conn.Close();
            relist();
            MessageBox.Show("Kayıt Silindi");
        }
    }
}
