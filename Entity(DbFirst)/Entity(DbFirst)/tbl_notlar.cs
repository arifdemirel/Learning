//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_DbFirst_
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_notlar
    {
        public int NOTID { get; set; }
        public Nullable<int> OGR { get; set; }
        public Nullable<int> DERS { get; set; }
        public Nullable<short> SINAV1 { get; set; }
        public Nullable<short> SINAV2 { get; set; }
        public Nullable<short> SINAV3 { get; set; }
        public Nullable<decimal> ORTALAMA { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual tbl_dersler tbl_dersler { get; set; }
        public virtual tbl_ogrenciler tbl_ogrenciler { get; set; }
    }
}