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
    
    public partial class personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personel()
        {
            this.urunfirsat = new HashSet<urunfirsat>();
            this.urunsiparis = new HashSet<urunsiparis>();
            this.arizaliurun = new HashSet<arizaliurun>();
            this.arizaliurunasamasi = new HashSet<arizaliurunasamasi>();
        }
    
        public int personel_ { get; set; }
        public string tc { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string tel1 { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> dogumtarihi { get; set; }
        public string sifre { get; set; }
        public Nullable<int> personeltip_ { get; set; }
        public Nullable<int> adres_ { get; set; }
        public Nullable<bool> sil { get; set; }
        public string cinsiyet { get; set; }
        public string tel2 { get; set; }
        public Nullable<int> egitimdurum { get; set; }
        public Nullable<double> maas { get; set; }
    
        public virtual adres adres { get; set; }
        public virtual personeltip personeltip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urunfirsat> urunfirsat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urunsiparis> urunsiparis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arizaliurun> arizaliurun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arizaliurunasamasi> arizaliurunasamasi { get; set; }
    }
}
