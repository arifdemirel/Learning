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
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }
        DBENTITYURUNEntities db = new DBENTITYURUNEntities();

        private void istatistik_Load(object sender, EventArgs e)
        {
            toplamkategorisayisi.Text=db.tbl_kategori.Count().ToString();
            toplamurunsayisi.Text=db.tbl_urun.Count().ToString();
            //sql syntax'ında kullanılan WHERE yerine burada yapılan eylemin ((count)) parantezine özel durum giriliyor
            aktifmusterisayisi.Text=db.tbl_musteri.Count(x => x.DURUM == true).ToString();
            pasifmusterisayisi.Text = db.tbl_musteri.Count(x => x.DURUM == false).ToString();
            toplamstok.Text = db.tbl_urun.Sum(x => x.STOK).ToString();
            beyazesyasayisi.Text = db.tbl_urun.Count(x => x.KATEGORI == 1).ToString();
            kasadakitutar.Text = db.tbl_satis.Sum(x => x.FIYAT).ToString()+ "TL";
            enyuksekfiyatliurun.Text = (from x in db.tbl_urun orderby x.FIYAT descending select x.URUN_AD).FirstOrDefault();
            endusukfiyatliurun.Text = (from x in db.tbl_urun orderby x.FIYAT ascending select x.URUN_AD).FirstOrDefault();
            //label 23'de herhangi bir elementin kaç tane olduğunu string vererek sorgulamayı yazdık
            toplambuzdolabisayisi.Text = db.tbl_urun.Count(x => x.URUN_AD == "BUZDOLABI").ToString();
            /*distinct komutu dizine her bir elementin bir kez atılmasını sağlar(birden fazla aynı değerde element olsa da) Count da
            gerisini görmezden gelir*/
            sehirsayisi.Text = (from x in db.tbl_musteri select x.MUSTERISEHIR ).Distinct().Count().ToString();
            //sql üzerinde oluşturduğumuz sorguyu(new query) Procedure olarak kaydettik ve procedure'u çalıştırıp ortaya çıkan veriyi buraya çağırdık
            enfazlaurunuolanmarka.Text = db.MARKAGETIR().FirstOrDefault().ToString();
        }

        private void btnanaekran_Click(object sender, EventArgs e)
        {
            anaform gurcan = new anaform();
            gurcan.Show();
            this.Hide();
        }
    }
}
