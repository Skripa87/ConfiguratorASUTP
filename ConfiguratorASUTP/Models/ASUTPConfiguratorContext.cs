using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ConfiguratorASUTP.Models
{
    public class ASUTPConfiguratorContext : DbContext
    {
        public ASUTPConfiguratorContext()
            : base("name=ASUTPConfigurator")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Condition>().HasKey(e => e.Id).HasRequired(h=>h.Type);
            modelBuilder.Entity<ConditionType>().HasKey(e => e.Id);
            modelBuilder.Entity<Impact>().HasKey(e => e.Id).HasRequired(h => h.Type);
            modelBuilder.Entity<ImpactType>().HasKey(e => e.Id);
            modelBuilder.Entity<Part>().HasKey(e => e.Id)
                                       .HasMany(m => m.Impacts)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("ImpactId").MapRightKey("PartId").ToTable("PartsImpacts"));
            modelBuilder.Entity<Part>().HasMany(m => m.Parts)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("InPartId").MapRightKey("PartId").ToTable("PartsParts"));
            modelBuilder.Entity<Part>().HasMany(m => m.Conditions)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("ConditionId").MapRightKey("PartId").ToTable("PartsConditions"));
            modelBuilder.Entity<Part>().HasMany(m => m.Properties)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("PropertyId").MapRightKey("PartId").ToTable("PartsProperties"));
            modelBuilder.Entity<Position>().HasKey(e => e.Id);


        }

        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<ConditionType> ConditionTypes { get; set; }
        public virtual DbSet<Impact> Impacts { get; set; }
        public virtual DbSet<ImpactType> ImpactTypes { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Profield> Profields { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<RemoteControl> RemoteControls { get; set; }
        public virtual DbSet<Value> Values { get; set; }
    }
}