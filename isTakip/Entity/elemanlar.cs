//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace isTakip.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class elemanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public elemanlar()
        {
            this.gorevler = new HashSet<gorevler>();
            this.gorevler1 = new HashSet<gorevler>();
        }
    
        public int id { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public Nullable<int> unvan { get; set; }
        public string sifre { get; set; }
        public string telefon { get; set; }
    
        public virtual unvan unvan1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gorevler> gorevler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gorevler> gorevler1 { get; set; }
    }
}
