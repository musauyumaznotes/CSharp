﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitySonKisim
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbSınavOgrenciEntities : DbContext
    {
        public DbSınavOgrenciEntities()
            : base("name=DbSınavOgrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLDERSLER> TBLDERSLER { get; set; }
        public virtual DbSet<TBLKULUPLER> TBLKULUPLER { get; set; }
        public virtual DbSet<TBLNOTLAR> TBLNOTLAR { get; set; }
        public virtual DbSet<TBLOGRENCI> TBLOGRENCI { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
    
        public virtual ObjectResult<NOTLISTESI_Result> NOTLISTESI()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NOTLISTESI_Result>("NOTLISTESI");
        }
    
        public virtual ObjectResult<Kulupler_Result> Kulupler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Kulupler_Result>("Kulupler");
        }
    }
}
