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
    public partial class sekretergiris : Form
    {
        public sekretergiris()
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
           
            msktc.Text = "11111111111";
            txtsifre.Text = "1234";
            SqlCommand command = new SqlCommand("Select * From Sekreter Where sekretertc=@p1 and sekretersifre=@p2", bgl._conn_());
            command.Parameters.AddWithValue("@p1", msktc.Text);
            command.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {sekreterdetay sd = new sekreterdetay();
                sd.sekretertc = msktc.Text;
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. & Şifre");
            }
            bgl._conn_().Close();
        }
    }
}
