﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InvestrositeEntities : DbContext
    {
        public InvestrositeEntities()
            : base("name=InvestrositeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Commnet> Commnets { get; set; }
        public virtual DbSet<Entrepreneur> Entrepreneurs { get; set; }
        public virtual DbSet<Investor> Investors { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
