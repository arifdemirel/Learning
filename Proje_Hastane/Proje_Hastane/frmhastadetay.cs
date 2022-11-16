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
    public partial class hastadetay : Form
    {
        public hastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        public string ad;
        public string soyad;

        sqlconnection bgl = new sqlconnection();
        private void hastadetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            //AD SOYADI TC değerini göndererek çekme
            SqlCommand command = new SqlCommand("SELECT  Hastaad,Hastasoyad From tbl_Hasta where Hastatc=@p1", bgl._conn_());
            command.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[0] + "";
                lblsoyad.Text = dr[1] + "";
            }
            bgl._conn_().Close();

            // Randevu Geçmişi
            DataTable dtrandevu = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("SELECT * FROM tbl_randevu WHERE Hastatc=" + tc, bgl._conn_());
            da5.Fill(dtrandevu);
            dataGridView1.DataSource = dtrandevu;


            //Branşları Çekme
            SqlCommand command2 = new SqlCommand("SELECT bransad FROM tlb_Branslar", bgl._conn_());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl._conn_().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("Select Doktorad,Doktorsoyad FROM tbl_doktorlar where Doktorbrans=@p1", bgl._conn_());
            command3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Clear();
                cmbdoktor.Text = " ";
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl._conn_();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable rgt = new DataTable();
            SqlDataAdapter rga = new SqlDataAdapter("SELECT * FROM tbl_randevu WHERE Randevubrans= ' " + cmbbrans.Text + "'" + " and Randevudoktor='" + cmbdoktor.Text + "' and Randevudurum=1", bgl._conn_());
            rga.Fill(rgt);
            dataGridView2.DataSource = rga;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bilgiduzenle bd = new bilgiduzenle();
            bd.tcno = lbltc.Text;
            bd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand randevual = new SqlCommand("UPDATE tbl_randevu Set Randevudurum=1, Hastatc=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl._conn_());
            randevual.Parameters.AddWithValue("@p1", lbltc.Text);
            randevual.Parameters.AddWithValue("@p2", rtbsikayet.Text);
            randevual.Parameters.AddWithValue("@p3", txtrandevu.Text);
            randevual.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Randevu Oluşturuldu/Güncellendi");
        }
    }
}
