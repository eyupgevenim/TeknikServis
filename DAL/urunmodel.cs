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
    
    public partial class urunmodel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urunmodel()
        {
            this.urunsepeti = new HashSet<urunsepeti>();
        }
    
        public int urunmodel_ { get; set; }
        public string modeladi { get; set; }
        public string modelkodu { get; set; }
        public Nullable<int> urunmarka_ { get; set; }
        public Nullable<double> ucret { get; set; }
        public Nullable<int> urunkatagori_ { get; set; }
        public Nullable<int> stoksayisi { get; set; }
        public Nullable<bool> sil { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual urunkatagori urunkatagori { get; set; }
        public virtual urunmarka urunmarka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urunsepeti> urunsepeti { get; set; }
    }
}
