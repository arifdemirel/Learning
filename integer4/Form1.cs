using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
private void button1_Click(object sender, EventArgs e)
        {
            int alan, kkenar, ukenar, cevre;
            kkenar = 20;
            ukenar = 10;
            alan = kkenar * ukenar;
            cevre = ukenar * 2 + kkenar * 2;
            label1.Text = "Çevre:" + cevre;
            label2.Text = "Alan" + alan;
        }
    
    }
}
