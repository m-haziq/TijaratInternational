﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace termProjectMvc.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities6 : DbContext
    {
        public Database1Entities6()
            : base("name=Database1Entities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<brand> brands { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<user1> user1 { get; set; }
    }
}
