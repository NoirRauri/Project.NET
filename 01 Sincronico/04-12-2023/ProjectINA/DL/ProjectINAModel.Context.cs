﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbProyectoINAEntities : DbContext
    {
        public dbProyectoINAEntities()
            : base("name=dbProyectoINAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbClientes> tbClientes { get; set; }
        public virtual DbSet<tbPersona> tbPersona { get; set; }
        public virtual DbSet<tbTipoClientes> tbTipoClientes { get; set; }
    }
}
