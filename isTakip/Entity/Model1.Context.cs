﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbIsTakipEntities : DbContext
    {
        public dbIsTakipEntities()
            : base("name=dbIsTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<birimler> birimler { get; set; }
        public virtual DbSet<elemanlar> elemanlar { get; set; }
        public virtual DbSet<gorevDetay> gorevDetay { get; set; }
        public virtual DbSet<gorevler> gorevler { get; set; }
        public virtual DbSet<islemBasliklari> islemBasliklari { get; set; }
        public virtual DbSet<islemDurmu> islemDurmu { get; set; }
        public virtual DbSet<islemler> islemler { get; set; }
        public virtual DbSet<mudurlukler> mudurlukler { get; set; }
        public virtual DbSet<unvan> unvan { get; set; }
    }
}
