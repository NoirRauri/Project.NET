﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MemoryGameEntities : DbContext
    {
        public MemoryGameEntities()
            : base("name=MemoryGameEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbJugadores> tbJugadores { get; set; }
        public virtual DbSet<tbRecordPlayers> tbRecordPlayers { get; set; }
        public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }
    }
}
