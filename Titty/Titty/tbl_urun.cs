//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Titty
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_urun()
        {
            this.tbl_satis = new HashSet<tbl_satis>();
        }
    
        public int URUN_ID { get; set; }
        public string URUN_AD { get; set; }
        public string MARKA { get; set; }
        public Nullable<short> STOK { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> KATEGORI { get; set; }
    
        public virtual tbl_kategori tbl_kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_satis> tbl_satis { get; set; }
    }
}
