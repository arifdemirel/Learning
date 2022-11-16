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
    public partial class doktordetay : Form
    {
        public doktordetay()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        public string doktortc;

        private void doktordetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = doktortc;
            SqlCommand getname = new SqlCommand("SELECT  Doktorad,Doktorsoyad FROM tbl_doktorlar where Doktortc=@p1", bgl._conn_());
            getname.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = getname.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[0] + " " + dr[1];
                
            }
            bgl._conn_().Close();
            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_randevu WHERE Randevudoktor=" + lblad.Text, bgl._conn_());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            duyurular dyr = new duyurular();
            dyr.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            doktorgiris dg = new doktorgiris();
            dg.Show();
            Hide();
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            bilgiduzenle bd = new bilgiduzenle();
            bd.Show();
        }
        
        
    }
}
