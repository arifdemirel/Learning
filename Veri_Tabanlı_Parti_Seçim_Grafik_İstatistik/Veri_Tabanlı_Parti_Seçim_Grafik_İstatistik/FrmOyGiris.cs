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

namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=CROMNA;Initial Catalog=Elections;Integrated Security=True");

        private void btnoygirisiyap_Click(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO tbl_ilce (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)",_conn);
            command.Parameters.AddWithValue("@P1",tbxilcead.Text);
            command.Parameters.AddWithValue("@P2",txtaparti.Text);
            command.Parameters.AddWithValue("@P3",txtbparti.Text);
            command.Parameters.AddWithValue("@P4",txtcparti.Text);
            command.Parameters.AddWithValue("@P5",txtdparti.Text);
            command.Parameters.AddWithValue("@P6",txteparti.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Oy Girişi Tamamlandı");
            _conn.Close();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler grafikler = new FrmGrafikler();
            grafikler.Show();
            this.Hide();
        }
    }
}
