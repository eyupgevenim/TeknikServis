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
    
    public partial class arizaliurun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public arizaliurun()
        {
            this.arizaliurunfotograf = new HashSet<arizaliurunfotograf>();
            this.arizaliurunasamasi = new HashSet<arizaliurunasamasi>();
        }
    
        public int arizaliurun_ { get; set; }
        public string urunadi { get; set; }
        public string urunkodu { get; set; }
        public Nullable<int> arizamusterisi_ { get; set; }
        public string aciklama { get; set; }
        public Nullable<int> durumu { get; set; }
        public Nullable<int> personel_ { get; set; }
        public string ariza { get; set; }
        public string tespitedilenariza { get; set; }
        public string sifre { get; set; }
        public Nullable<int> teknikeleman_ { get; set; }
        public string model { get; set; }
        public string urunaksesuar { get; set; }
        public Nullable<double> arizabedeli { get; set; }
        public Nullable<int> serviskapsam { get; set; }
        public Nullable<System.DateTime> kayittarih { get; set; }
    
        public virtual arizamusterisi arizamusterisi { get; set; }
        public virtual personel personel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arizaliurunfotograf> arizaliurunfotograf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arizaliurunasamasi> arizaliurunasamasi { get; set; }
    }
}
