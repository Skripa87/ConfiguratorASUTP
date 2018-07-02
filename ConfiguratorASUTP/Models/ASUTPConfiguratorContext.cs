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
            var part = modelBuilder.Entity<Part>()
                                   .ToTable("Parts", "public");
            part.HasKey(p => p.Part_Id);
            modelBuilder.Entity<Condition>()
                                         .ToTable("Conditions", "public")
                                         .HasKey(e => e.Id)
                                         .HasRequired(h => h.Type);
            modelBuilder.Entity<ConditionType>()
                        .ToTable("ConditionType", "public")
                        .HasKey(e => e.Id);
            modelBuilder.Entity<Impact>()
                        .ToTable("Impacts", "public")
                        .HasKey(e => e.Id)
                        .HasRequired(h => h.Type);
            modelBuilder.Entity<ImpactType>()
                        .ToTable("ImpactTypes", "public")
                        .HasKey(e => e.Id);
            part.HasMany(m => m.Conditions)
                .WithMany(em => em.Parts)
                .Map(mm => mm.MapLeftKey("PartsConditions_PartId")
                             .MapRightKey("PartsConditions_ConditionId")
                             .ToTable("PartsConditions", "public"));
            part.HasMany(m => m.Properties)
                .WithMany(em => em.Parts)
                .Map(mm => mm.MapLeftKey("PartsProperties_PartId")
                             .MapRightKey("PartsProperties_PropertyId")
                             .ToTable("PartsProperties", "public"));
            part.HasOptional(p => p.Part_Position)
                .WithMany(u => u.Parts)
                .Map(mm => mm.MapKey("Part_Position"));
            part.HasOptional(p => p.Part_Profield)
                .WithMany(u => u.Parts)
                .Map(mm => mm.MapKey("Part_Profield"));
            part.HasOptional(p => p.Part_Owner)
                .WithMany(u => u.Childs)
                .Map(mm => mm.MapKey("Part_Owner"));
            modelBuilder.Entity<Position>()
                        .ToTable("Positions", "public")
                        .HasKey(e => e.Id);
            modelBuilder.Entity<Profield>()
                        .ToTable("Profields", "public")
                        .HasKey(e => e.ProfieldId);
            modelBuilder.Entity<Property>()
                        .ToTable("Properties", "public")
                        .HasKey(e => e.Id)
                        .HasMany(p=>p.Values)
                        .WithMany(v=>v.Properties)
                        .Map(mm=>mm.MapLeftKey("PropertiesValues_PropertyId")
                                   .MapRightKey("PropertiesValues_ValueId")
                                   .ToTable("PropertiesValues"));
            modelBuilder.Entity<PropertyType>()
                        .ToTable("PropertyTypes", "public")
                        .HasKey(e => e.Id);
            var remotecontrol = modelBuilder.Entity<RemoteControl>()
                                            .ToTable("RemoteControls", "public")
                                            .HasKey(e => e.RemoteControl_Id);
            remotecontrol.HasMany(r => r.Parts)
                         .WithMany(w => w.RemoteControls)
                         .Map(mm => mm.MapLeftKey("RemoteControlsParts_PartsId")
                                      .MapRightKey("RemoteControlsParts_RemoteControlId")
                                      .ToTable("RemoteControlsParts"));
            remotecontrol.HasMany(r => r.Properties)
                         .WithMany(w => w.RemoteControls)
                         .Map(mm => mm.MapLeftKey("RemoteControlsProperties_RemoteControlId")
                                      .MapRightKey("RemoteControlsProperties_PropertyId")
                                      .ToTable("RemoteControlsProperties"));
            modelBuilder.Entity<Value>()
                        .ToTable("Values", "public")
                        .HasKey(e => e.Id);
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