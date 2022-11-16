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
    public partial class frmhasta : Form
    {
        public frmhasta()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayit fr = new frmhastakayit();
            fr.Show();
        }

        private void btnhastagirisyap_Click(object sender, EventArgs e)
        {
            msktc.Text = 26318624844.ToString();
            txttc.Text = 88316660.ToString();
            SqlCommand command = new SqlCommand("Select * From tbl_Hasta Where Hastatc=@p1 and Hastasifre=@p2", bgl._conn_());
            command.Parameters.AddWithValue("@p1", msktc.Text);
            command.Parameters.AddWithValue("@p2", txttc.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                hastadetay fr = new hastadetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. & Şifre");
            }
            bgl._conn_().Close();

        }

        private void btnanapanel_Click(object sender, EventArgs e)
        {
            frmgirisler fr = new frmgirisler();
            fr.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)

        {
            
           
        }
    }
}
