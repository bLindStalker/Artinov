﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TvAppDBaseEntities : DbContext
    {
        public TvAppDBaseEntities()
            : base("name=TvAppDBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AdditionalServices> AdditionalServices { get; set; }
        public virtual DbSet<Channels> Channels { get; set; }
        public virtual DbSet<OrderChannels> OrderChannels { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderServices> OrderServices { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<TvShows> TvShows { get; set; }
        public virtual DbSet<TypeConnects> TypeConnects { get; set; }
        public virtual DbSet<UserAddresses> UserAddresses { get; set; }
        public virtual DbSet<UserEmails> UserEmails { get; set; }
        public virtual DbSet<UserPhones> UserPhones { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSchedules> UserSchedules { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }
    }
}