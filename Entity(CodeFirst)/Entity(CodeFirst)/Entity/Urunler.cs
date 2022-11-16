using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_CodeFirst_.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        //[StringLength(50)] veya [MaxLength(50)] kullanarak veritabanı varchar uzunluğu belirtilebilir

        [StringLength(50)]
        public string UrunAd { get; set; }
        [StringLength(50)]
        public string UrunMarka { get; set; }
        [MaxLength(50)]
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }

        [MaxLength(50)]
        public string Aciklama { get; set; }

        
        //burada
        public Kategori Kategori { get; set; }
        
    }
}
