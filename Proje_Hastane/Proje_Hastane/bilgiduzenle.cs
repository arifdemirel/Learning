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
    public partial class bilgiduzenle : Form
    {
        public bilgiduzenle()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        public string tcno;

        private void btnguncelle_Click(object sender, EventArgs e)
            
        {
            SqlCommand update = new SqlCommand("UPDATE tbl_Hasta SET Hastatc=@p1,Hastaad=@p2,Hastasoyad=@p3,Hastatelefon=@p4,Hastasifre=@p5,Hastacinsiyet=@p6 WHERE Hastatc=@p1 ", bgl._conn_());
            update.Parameters.AddWithValue("@p1", msktc.Text);
            update.Parameters.AddWithValue("@p2", txtad.Text);
            update.Parameters.AddWithValue("@p3", txtsoyad.Text);
            update.Parameters.AddWithValue("@p4", msktelefon.Text);
            update.Parameters.AddWithValue("@p5", msksifre.Text);
            update.Parameters.AddWithValue("@p6", cboxcinsiyet.Text);
            update.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir, Şifreniz:" + msksifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bilgiduzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tcno;
            SqlCommand command = new SqlCommand("SELECT * from tbl_Hasta WHERE Hastatc=@p1", bgl._conn_());
            command.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                msksifre.Text = dr[5].ToString();
                cboxcinsiyet.Text = dr[6].ToString();
           
            }
            bgl._conn_().Close();
        }
    }
}
