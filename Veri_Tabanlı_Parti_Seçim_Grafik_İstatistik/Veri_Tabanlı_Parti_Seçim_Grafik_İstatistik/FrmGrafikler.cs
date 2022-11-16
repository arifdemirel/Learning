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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=CROMNA;Initial Catalog=Elections;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("Select ILCEAD from tbl_ilce", _conn);
            SqlDataReader dr = command.ExecuteReader();
            
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            _conn.Close();

            //Calling results to graphic

            _conn.Open();
            SqlCommand command2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM tbl_ilce", _conn);
            SqlDataReader dr2 = command2.ExecuteReader();
            while(dr2.Read()) 
            {
                chart1.Series["Partiler"].Points.AddXY("APARTİ",dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("BPARTİ",dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("CPARTİ",dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("DPARTİ",dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("EPARTİ",dr2[4]);
            }
            _conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand("Select * FROM tbl_ilce where ILCEAD=@p1", _conn);
            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            double totalVotes;
            while(dr.Read()) 
            {
                baraparti.Value = int.Parse(dr[2].ToString());
                barbparti.Value = int.Parse(dr[3].ToString());
                barcparti.Value = int.Parse(dr[4].ToString());
                bardparti.Value = int.Parse(dr[5].ToString());
                bareparti.Value = int.Parse(dr[6].ToString());

                lbla.Text = dr[2].ToString();
                lblb.Text = dr[3].ToString();
                lblc.Text = dr[4].ToString();
                lbld.Text = dr[5].ToString();
                lble.Text = dr[6].ToString();

                totalVotes = double.Parse(lbla.Text) + double.Parse(lblb.Text) +double.Parse(lblc.Text) +double.Parse(lbld.Text)+ double.Parse(lble.Text);
                lblparta.Text = "%" + ((double.Parse(lbla.Text) * 100)/totalVotes).ToString();
                lblpartb.Text = "%" + (double.Parse(lblb.Text) * 100 / totalVotes).ToString();
                lblpartc.Text = "%" + (double.Parse(lblc.Text) * 100/totalVotes).ToString(); 
                lblpartd.Text = "%" + (double.Parse(lbld.Text) * 100/totalVotes).ToString(); 
                lblparte.Text = "%" + (double.Parse(lble.Text) * 100/totalVotes).ToString(); 
            }
            _conn.Close();
        }
    }
}
