using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class sekreterdetay : Form
    {
        public sekreterdetay()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        public string sekretertc;
        public string ad;
        public string soyad;
        public string currentvalue;
        private void sekreterdetay_Load(object sender, EventArgs e)
        {

            txtid.Text = currentvalue;
            mtbsekretertc.Text = sekretertc;
            SqlCommand command = new SqlCommand("SELECT  sekreterad,sekretersoyad From Sekreter where sekretertc=@p1", bgl._conn_());
            command.Parameters.AddWithValue("@p1", mtbsekretertc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblsekreterad.Text = dr[0] + "";
                lblsekretersoyad.Text = dr[1] + "";
            }
            bgl._conn_().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * from tlb_branslar", bgl._conn_());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            bgl._conn_().Close();

            DataTable dt2 = new DataTable();
            //as ilgili parametrelerin yazıldığı sütuna bir isim vermek için kullanılabilir. As'den sonra gelecek isim(ler)in önüne ve arkasına KESME İŞARETİ(') KOYULUR.
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (Doktorad+' '+ Doktorsoyad) AS 'Doktorlar',Doktorbrans AS 'Doktor Branş' FROM tbl_doktorlar", bgl._conn_());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı combox'A aktarma
            SqlCommand writebranches = new SqlCommand("SELECT bransAd FROM tlb_Branslar", bgl._conn_());
            SqlDataReader dr2 = writebranches.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl._conn_().Close();

            /*SqlCommand randevugetir = new SqlCommand("SELECT  Randevutarih,RandevuSaat, Randevubrans, RandevuDoktor,Hastatc From tbl_randevu where Randevuid=@p1", bgl._conn_());
            randevugetir.Parameters.AddWithValue("@p1", txtid.Text);
            SqlDataReader rdr = randevugetir.ExecuteReader();
            while (rdr.Read())
            {
                mtbtarih.Text = rdr[0].ToString();
                mtbsaat.Text = rdr[1].ToString();
                cmbbrans.Text = rdr[2].ToString();
                cmbdoktor.Text = rdr[3].ToString();
                mtbhastatc.Text = rdr[4].ToString(); ;
            }
            bgl._conn_().Close();*/
        }

        private void btnkaydet_Click(object sender, EventArgs e)



        {
            SqlCommand save = new SqlCommand("INSERT INTO tbl_randevu(Randevutarih, Randevusaat, Randevubrans, Randevudoktor, Hastatc) VALUES(@p1, @p2, @p3, @p4, @p5)", bgl._conn_());
            save.Parameters.AddWithValue("@p1", mtbtarih.Text);
            save.Parameters.AddWithValue("@p2", mtbsaat.Text);
            save.Parameters.AddWithValue("@p3", cmbbrans.Text);
            save.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            save.Parameters.AddWithValue("@p5", mtbhastatc.Text);
            save.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("UPDATE tbl_randevu SET Randevutarih=@p1,Randevusaat=@p2,Randevubrans=@p3,Randevudoktor=@p4 WHERE mtbhastatc=@p5", bgl._conn_());
            update.Parameters.AddWithValue("@p1", mtbtarih.Text);
            update.Parameters.AddWithValue("@p2", mtbsaat.Text);
            update.Parameters.AddWithValue("@p3", cmbbrans.Text);
            update.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            update.Parameters.AddWithValue("@p5", mtbhastatc);
            update.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Randevu Güncellendi");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbdoktor.Items.Clear();
            cmbdoktor.Text = " ";

            SqlCommand doktorgetir = new SqlCommand("SELECT Doktorad,Doktorsoyad FROM tbl_doktorlar where Doktorbrans=@p1", bgl._conn_());
            doktorgetir.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = doktorgetir.ExecuteReader();

            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl._conn_().Close();

        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuru = new SqlCommand("INSERT INTO tbl_duyurular (duyuru) values (@d1)", bgl._conn_());
            duyuru.Parameters.AddWithValue("@d1", rtbduyuru.Text);
            duyuru.ExecuteNonQuery();
            bgl._conn_().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            doktorpaneli drp = new doktorpaneli();
            drp.Show();
            Hide();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            branspaneli bp = new branspaneli();
            bp.tcsekreter = mtbsekretertc.Text;
            bp.Show();
            Hide();

        }

        private void sekretergiris_Click(object sender, EventArgs e)
        {
            sekretergiris sg = new sekretergiris();
            sg.Show();
            Hide();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            Randevuliste rl = new Randevuliste();
            rl.Show();
            Hide();

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            duyurular dyr = new duyurular();
            dyr.Show();
        }
    }

}
