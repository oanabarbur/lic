﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Licenta.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BazaLicentaEntities : DbContext
    {
        public BazaLicentaEntities()
            : base("name=BazaLicentaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Echipamente> Echipamentes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Unitate> Unitates { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
    }
}
