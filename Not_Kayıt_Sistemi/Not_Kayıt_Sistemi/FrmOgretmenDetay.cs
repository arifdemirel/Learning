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

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=CROMNA;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet2.tbl_matematik' table. You can move, or remove it, as needed.
            this.tbl_matematikTableAdapter2.Fill(this.dbNotKayitDataSet2.tbl_matematik);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("insert into tbl_matematik (OGRNO,OGRAD,OGRSOYAD)VALUES (@P1,@p2,@p3)", _conn);
            command.Parameters.AddWithValue("@p1", MskNumber.Text);
            command.Parameters.AddWithValue("@p2", TxtAd.Text);
            command.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            command.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("işlem halledildi");
            this.tbl_matematikTableAdapter2.Fill(this.dbNotKayitDataSet2.tbl_matematik);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            MskNumber.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblsinifortalama.Text = ortalama.ToString();

            if(ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }


            _conn.Open();
            SqlCommand command = new SqlCommand("update tbl_matematik set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@p4,DURUM=@P5 WHERE OGRNO=@p6", _conn);
            command.Parameters.AddWithValue("@p1", TxtSinav1.Text);
            command.Parameters.AddWithValue("@p2", TxtSinav2.Text);
            command.Parameters.AddWithValue("@p3", TxtSinav3.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(lblsinifortalama.Text));
            command.Parameters.AddWithValue("@p5", durum);
            command.Parameters.AddWithValue("@p6", MskNumber.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("işlem tamam");
            _conn.Close();

            _conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select Count (*) FROM tbl_matematik where durum=1", _conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblgecensayisi.Text = dr3[0].ToString();
            }

            _conn.Close();

            _conn.Open();
            

            SqlCommand cmd4 = new SqlCommand("Select Count (*) FROM tbl_matematik where durum=0", _conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblkalansayisi.Text = dr4[0].ToString();
            }
            _conn.Close();


            this.tbl_matematikTableAdapter2.Fill(this.dbNotKayitDataSet2.tbl_matematik);
        }
    }
}
