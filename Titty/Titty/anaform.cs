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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            Kategori fr = new Kategori();
            fr.Show();
            this.Hide();
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            this.Hide();
            urun rn = new urun();
            rn.Show();

        }

        private void btnistatistikler_Click(object sender, EventArgs e)
        {
            this.Hide();
            istatistik gurcan = new istatistik();
            gurcan.Show();
        }
    }
}
