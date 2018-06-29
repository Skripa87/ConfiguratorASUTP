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
            var part = modelBuilder.Entity<Part>().ToTable("public.parts");
            part.HasKey(p => p.Part_Id);
            modelBuilder.Entity<Condition>().ToTable("public.conditions").HasKey(e => e.Id).HasRequired(h => h.Type);
            modelBuilder.Entity<ConditionType>().ToTable("public.conditiontype").HasKey(e => e.Id);
            modelBuilder.Entity<Impact>().ToTable("public.impacts").HasKey(e => e.Id).HasRequired(h => h.Type);
            modelBuilder.Entity<ImpactType>().ToTable("public.impacttypes").HasKey(e => e.Id);
            modelBuilder.Entity<AssemblyPart>().ToTable("public.assemblyparts").HasKey(e => e.Id);
            //modelBuilder.Entity<Part>().HasKey(e => e.Id)
            //                           .HasMany(m => m.Impacts)
            //                           .WithMany(em => em.Parts)
            //                           .Map(mm => mm.MapLeftKey("ImpactId").MapRightKey("PartId").ToTable("PartsImpacts"));
            /*modelBuilder.Entity<Part>()*/part.HasMany(m => m.Part_Conditions)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("partsconditions_partid").MapRightKey("partsconditions_conditionid").ToTable("public.partsconditions"));
            /*modelBuilder.Entity<Part>()*/part.HasMany(m => m.Part_Properties)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("partsproperties_partid").MapRightKey("partsproperties_propertyid").ToTable("public.partsproperties"));
            /*modelBuilder.Entity<Part>()*/part.HasKey(e => e.Part_Id)
                                       .HasMany(m => m.Part_Assemblies)
                                       .WithMany(em => em.Parts)
                                       .Map(mm => mm.MapLeftKey("partsinassemblyparts_partid").MapRightKey("partsinassemblyparts_assemblyId").ToTable("public.partsinassemblyparts"));
            modelBuilder.Entity<Position>()
                        .ToTable("public.positions", "public")
                        .HasKey(e => e.Id);
            modelBuilder.Entity<Profield>()
                        .ToTable("public.profields", "public")
                        .HasKey(e => e.ProfieldId);
            modelBuilder.Entity<Property>()
                        .ToTable("public.properties", "public")
                        .HasKey(e => e.Id);
            modelBuilder.Entity<PropertyType>()
                        .ToTable("public.propertytypes", "public")
                        .HasKey(e => e.Id);
            modelBuilder.Entity<RemoteControl>()
                        .ToTable("public.remoteControls", "public")
                        .HasKey(e => e.Id);
            modelBuilder.Entity<Value>()
                        .ToTable("public.values", "public")
                        .HasKey(e => e.Id);
        }

        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<ConditionType> ConditionTypes { get; set; }
        public virtual DbSet<Impact> Impacts { get; set; }
        public virtual DbSet<ImpactType> ImpactTypes { get; set; }
        public virtual DbSet<AssemblyPart> AssemblyParts { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Profield> Profields { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<RemoteControl> RemoteControls { get; set; }
        public virtual DbSet<Value> Values { get; set; }
    }
}