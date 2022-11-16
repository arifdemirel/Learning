using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Entity_CodeFirst_.Entity
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        [StringLength(25)]
        public string MusteriAd { get; set; }

        [StringLength(25)]
        public string MusteriSoyad { get; set; }

        [StringLength(25)]
        public string MusteriSehir { get; set; }


        //  update-database       Enable-Migration
        //  add-migration CreateMusteriTable (yeni tablo oluşturma)   veri tabanına da yansıması için, update-database komutu çalıştırılmalı

        //  codefirst'de önce buradaki işi bitirir. sonra veritabanına yazarız

        //  PM> VS Studio da Tablo ismi değişir - add-migration CreateMusteriSehirColumnInMusteriTable  - sonunda, update-database
        //  yukarıda açıklanan yöntem column'u komple siler ve yeni isimle bir column oluşturur

        
    }
}
