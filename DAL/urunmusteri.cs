//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class urunmusteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urunmusteri()
        {
            this.urunsiparis = new HashSet<urunsiparis>();
        }
    
        public int urunmusteri_ { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public Nullable<int> adres_ { get; set; }
        public Nullable<int> musteritip { get; set; }
        public Nullable<bool> sil { get; set; }
        public Nullable<int> firma_ { get; set; }
        public Nullable<System.DateTime> kayittarihi { get; set; }
        public string tel2 { get; set; }
        public string email2 { get; set; }
    
        public virtual adres adres { get; set; }
        public virtual firma firma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urunsiparis> urunsiparis { get; set; }
    }
}
