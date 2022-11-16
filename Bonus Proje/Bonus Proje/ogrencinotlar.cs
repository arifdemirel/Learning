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
    public partial class ogrencinotlar : Form
    {
        public ogrencinotlar()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-KVIRVD3;Initial Catalog=Bonus_okul;Integrated Security=True");
        public string number;

        
        private void ogrencinotlar_Load(object sender, EventArgs e)
        {
            
            _conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_notlar INNER JOIN tbl_dersler ON tbl_notlar.DERSID=tbl_dersler.DERSID WHERE OGRID=@p1", _conn);
            command.Parameters.AddWithValue("@p1",number);
            //this.Text = number.ToString();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            _conn.Close();

            _conn.Open();
            SqlCommand command2 = new SqlCommand("SELECT OGRAD,OGRSOYAD FROM tbl_ogrenciler where OGRID=1",_conn);
           command2.Parameters.AddWithValue("@p1",number);
            SqlDataReader dr1 = command2.ExecuteReader();
            while (dr1.Read())
            {
                this.Text = dr1[0] + " " + dr1[1].ToString();
            }
            _conn.Close();
        }
        
        
        
    }
}
