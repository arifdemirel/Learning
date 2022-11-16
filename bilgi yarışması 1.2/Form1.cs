using System;
using System.Windows.Forms;

namespace bilgi_yarışması_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        
        private void CEVAP_A_Click(object sender, EventArgs e)
        {

            VERILENCEVAP.Text = CEVAP_A.Text;
            CEVAP_A.Enabled = false;
            CEVAP_B.Enabled = false;
            CEVAP_C.Enabled = false;
            CEVAP_D.Enabled = false;
            button5.Enabled = true;
            if (DOGRUCEVAP.Text == VERILENCEVAP.Text)
            {
                dogru++;
                dogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void CEVAP_B_Click(object sender, EventArgs e)
        {
            VERILENCEVAP.Text = CEVAP_B.Text;
            CEVAP_A.Enabled = false;
            CEVAP_B.Enabled = false;
            CEVAP_C.Enabled = false;
            CEVAP_D.Enabled = false;
            button5.Enabled = true;
            if (DOGRUCEVAP.Text == VERILENCEVAP.Text)
            {
                dogru++;
                dogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void CEVAP_C_Click(object sender, EventArgs e)
        {
            VERILENCEVAP.Text = CEVAP_C.Text;
            CEVAP_A.Enabled = false;
            CEVAP_B.Enabled = false;
            CEVAP_C.Enabled = false;
            CEVAP_D.Enabled = false;
            button5.Enabled = true;
            if (DOGRUCEVAP.Text == VERILENCEVAP.Text)

            {
                dogru++;
                dogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void CEVAP_D_Click(object sender, EventArgs e)
        {
            VERILENCEVAP.Text = CEVAP_D.Text;
            CEVAP_A.Enabled = false;
            CEVAP_B.Enabled = false;
            CEVAP_C.Enabled = false;
            CEVAP_D.Enabled = false;
            button5.Enabled = true;
            if (DOGRUCEVAP.Text == VERILENCEVAP.Text)
            {
                dogru++;
                dogrusayisi.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlissayisi.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void DOGRUCEVAP_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CEVAP_A.Enabled = true;
            CEVAP_B.Enabled = true;
            CEVAP_C.Enabled = true;
            CEVAP_D.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            sorusayisi.Text = soruno.ToString();

            if (soruno == 1)
            {
                
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                CEVAP_A.Text = "1920";
                CEVAP_B.Text = "1921";
                CEVAP_C.Text = "1922";
                CEVAP_D.Text = "1923";
                DOGRUCEVAP.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi İl Ege bölgemizde bulunmaz?";
                CEVAP_A.Text = "İzmir";
                CEVAP_B.Text = "Balıkesir";
                CEVAP_C.Text = "Aydın";
                CEVAP_D.Text = "Manisa";
                DOGRUCEVAP.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Güvercinim Uyur mu hangi yazarımıza aittir?";
                CEVAP_A.Text = "Sait Faik Abasıyanık";
                CEVAP_B.Text = "Orhan Veli Kanık";
                CEVAP_C.Text = "Nazım Hikmet";
                CEVAP_D.Text = "Rıfat Ilgaz";
                DOGRUCEVAP.Text = "Rıfat Ilgaz";
                button5.Text = "Sonuclar";
            }
            if (soruno == 4)
            {
                CEVAP_A.Enabled = false;
                CEVAP_B.Enabled = false;
                CEVAP_C.Enabled = false;
                CEVAP_D.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru" +" "+  dogru +" "+ "Yanlış"+ " "+ yanlis);
            }


        }

    }
}
