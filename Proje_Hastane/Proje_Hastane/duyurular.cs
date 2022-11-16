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
    public partial class duyurular : Form
    {
        public duyurular()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        private void duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_duyurular", bgl._conn_());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            bgl._conn_().Close();
        }
    }
}
