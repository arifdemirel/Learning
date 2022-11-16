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
    public partial class doktorgiris : Form
    {
        public doktorgiris()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        private void btnanapanel_Click(object sender, EventArgs e)
        {
            frmgirisler fr = new frmgirisler();
            fr.Show();
            this.Hide();
        }

        private void btnhastagirisyap_Click(object sender, EventArgs e)
        {
            msktc.Text = "5555555555";
            txtsifre.Text = "1234";
            SqlCommand login = new SqlCommand("Select * From tbl_doktorlar Where Doktortc=@p1 and Doktorsifre=@p2", bgl._conn_());
            login.Parameters.AddWithValue("@p1", msktc.Text);
            login.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = login.ExecuteReader();
            if (dr.Read())
            {
                doktordetay dd = new doktordetay();
                dd.doktortc = msktc.Text;
                dd.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. & Şifre");
            }
            bgl._conn_().Close();
        }
    }
}
