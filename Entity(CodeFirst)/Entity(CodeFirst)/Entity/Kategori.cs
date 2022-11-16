using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_CodeFirst_.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        public string KategoriName { get; set; }

        public string KategoriDetay { get; set; }


        //bu sınıfta ve ürünler sınıfında birbirlerinin classlarıyla nesne oluşturmak suretiyle SQL diagramında ilişki oluşturduk.
        public ICollection<Urunler> Urunler { get; set; }
    }


    // add-migration KategoriADIToKategoriAdInKategoriTable dedikten sonra
    // yeni oluşturulmuş Migration Class'A geçeriz ve

}
