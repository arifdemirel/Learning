using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace openfile_savefile_folderbrowser
{
    public partial class pdfokutma : Form
    {
        public pdfokutma()
        {
            InitializeComponent();
        }
        private void pdfokutma_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            if (pdfac.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(pdfac.FileName);
            }
        }
    }
}
