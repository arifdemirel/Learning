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

namespace Bonus_Okul
{
    public partial class kulupler : Form
    {
        public kulupler()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection("Data Source = DESKTOP - KVIRVD3; Initial Catalog = Bonus_okul; Integrated Security = True");
        private void kulupler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bonus_okulDataSet.tbl_kulupler' table. You can move, or remove it, as needed.
            this.tbl_kuluplerTableAdapter.Fill(this.bonus_okulDataSet.tbl_kulupler);

        }
        void relist()
        {

            this.tbl_kuluplerTableAdapter.Fill(this.bonus_okulDataSet.tbl_kulupler);

        }

        private void kulup_Shown(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_kulupler", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
