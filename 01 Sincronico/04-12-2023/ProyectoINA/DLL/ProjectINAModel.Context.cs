﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLL
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbProyectoINAEntities1 : DbContext
    {
        public dbProyectoINAEntities1()
            : base("name=dbProyectoINAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbClientes> tbClientes { get; set; }
        public virtual DbSet<tbPersona> tbPersona { get; set; }
        public virtual DbSet<tbRoles> tbRoles { get; set; }
        public virtual DbSet<tbTipoClientes> tbTipoClientes { get; set; }
        public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }
    }
}
