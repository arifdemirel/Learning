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

namespace Not_Kayit_Sistemi
{
    public partial class ogrencinotsistemi : Form
    {
        public ogrencinotsistemi()
        {
            InitializeComponent();
        }

        public string numara;
        SqlConnection _conn = new SqlConnection(@"Data Source=CROMNA;Initial Catalog=DbNotKayit;Integrated Security=True");
        //Data Source=CROMNA;Initial Catalog=DbNotKayit;Integrated Security=True
        private void ogrencinotsistemi_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;


            _conn.Open();
            SqlCommand command = new SqlCommand("Select * From tbl_matematik where OGRNO=@p1",_conn);
            //command.Connection = _conn;  baglantıyı burada ilişkilendirebiliriz veya yukarıda virgülden sonra da yazabiliriz.
            command.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblogrenciadsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblsinav1.Text = dr[4].ToString();
                lblsinav2.Text = dr[5].ToString();
                lblsinav3.Text = dr[6].ToString();
                lblortalama.Text = dr[7].ToString();
                if(lbldurum.Text== "True")
                {
                    lbldurum.Text = "Geçti";
                }
                else
                {
                    lbldurum.Text = "Kaldı";
                }
                

            }
            _conn.Close();
        }
    }
}
