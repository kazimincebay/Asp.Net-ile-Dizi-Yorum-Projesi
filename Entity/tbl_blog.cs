//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diziYorum.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_blog()
        {
            this.tbl_yorum = new HashSet<tbl_yorum>();
        }
    
        public int blogId { get; set; }
        public string blogBaslik { get; set; }
        public string blogIcerik { get; set; }
        public Nullable<System.DateTime> blogTarih { get; set; }
        public string blogGorsel { get; set; }
        public Nullable<byte> blogTur { get; set; }
        public Nullable<byte> blogKategori { get; set; }
    
        public virtual tbl_kategori tbl_kategori { get; set; }
        public virtual tbl_tur tbl_tur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_yorum> tbl_yorum { get; set; }
    }
}
