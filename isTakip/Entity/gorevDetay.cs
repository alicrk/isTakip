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
    
    public partial class gorevDetay
    {
        public int id { get; set; }
        public Nullable<int> gorev { get; set; }
        public string aciklama { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual gorevler gorevler { get; set; }
    }
}
