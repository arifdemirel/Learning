using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarışması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlis = 0;

        private void SIK1_Click(object sender, EventArgs e)
        {
            ANSWERHOLDER.Text = SIK1.Text;
            if (label1.Text == ANSWERHOLDER.Text)

                doğru++;
            label5.Text = DOGRU.ToString();
            DOGRU.Visible = true;
        }
        
        public object CEVAP1 { get; private set; }

        private void SONRAKI_Click(object sender, EventArgs e)
        {
            soruno++;
            label4.Text = soruno.ToString();
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                SIK1.Text = "1920";
                SIK2.Text = "1921";
                SIK3.Text = "1922";
                SIK4.Text = "1923";
                label1.Text = "1923";
            }
                    if (soruno == 2)
            {
                richTextBox1.Text = "Hangi İl Ege bölgemizde bulunmaz?";
                SIK1.Text = "İzmir";
                SIK2.Text = "Balıkesir";
                SIK3.Text = "Aydın";
                SIK4.Text = "Manisa";
                    label2.Text = "Balıkesir";
            }
                    if (soruno == 3) 
            {
                richTextBox1.Text = "Güvercinim Uyur mu hangi yazarımıza aittir?";
                SIK1.Text = "Sait Faik Abasıyanık";
                SIK2.Text = "Orhan Veli Kanık";
                SIK3.Text = "Nazım Hikmet";
                SIK4.Text = "Rıfat Ilgaz";
                label3.Text = "Rıfat Ilgaz";
            }
                {
                }
            }
        }
    }

