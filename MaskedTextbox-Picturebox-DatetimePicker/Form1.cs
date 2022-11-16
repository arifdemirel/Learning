using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextbox_Picturebox_DatetimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = listBox1.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2 + " " + maskedTextBox3 + " " + maskedTextBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
