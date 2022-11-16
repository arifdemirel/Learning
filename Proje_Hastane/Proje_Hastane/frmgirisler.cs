using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            frmhasta hasta = new frmhasta();
            hasta.Show();
            this.Hide();
        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            doktorgiris doktor = new doktorgiris();
            doktor.Show();
            this.Hide();
        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            sekretergiris sekreter = new sekretergiris();
            sekreter.Show();
            this.Hide();
        }
    }
}
