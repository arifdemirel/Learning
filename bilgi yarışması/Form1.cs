using System;
using System.Windows.Forms;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno=0,dogru=0,yanlis=0;

        private void BTNB_Click(object sender, EventArgs e)
        {

        }

        private void BTNA_Click(object sender, EventArgs e)
        {
            CEVAP = BTNA.Text;
            if   

        }

        private void BTNSONRAKI_Click(object sender, EventArgs e)
        {
            soruno++;
            LBLSORUNO.Text=soruno.ToString();

            if(soruno ==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BTNA.Text = "1920";
                BTNB.Text = "1921";
                BTNC.Text = "1922";
                BTND.Text = "1923";
                CEVAP.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi İl Ege bölgemizde bulunmaz?";
                BTNA.Text = "İzmir";
                BTNB.Text = "Balıkesir";
                BTNC.Text = "Aydın";
                BTND.Text = "Manisa";
                CEVAP.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Güvercinim Uyur mu hangi yazarımıza aittir?";
                BTNA.Text = "Sait Faik Abasıyanık";
                BTNB.Text = "Orhan Veli Kanık";
                BTNC.Text = "Nazım Hikmet";
                BTND.Text = "Rıfat Ilgaz";
                CEVAP.Text = "Rıfat Ilgaz";
            }
        }
    }
}
