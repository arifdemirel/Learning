using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titty
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            DBENTITYURUNEntities db = new DBENTITYURUNEntities();
            var query = from x in db.tbl_admin where x.USERNAME == txtad.Text && x.PASSWORD == txtsifre.Text select x;
            if(query.Any())
            {
                anaform gurcan = new anaform();
                gurcan.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}
