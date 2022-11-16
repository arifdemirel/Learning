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
    public partial class Randevuliste : Form
    {
        public Randevuliste()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        private void Randevuliste_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_randevu", bgl._conn_());
            da.Fill(dt);
            dataGridView1.DataSource=(dt);

        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sekreterdetay sd = new sekreterdetay();
            sd.currentvalue = dataGridView1.SelectedCells[0].RowIndex.ToString();
            sd.Show();
            Hide();
        }
    }
}
