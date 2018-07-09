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
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<RemoteControl>()
                        .HasKey(r => r.Id)
                        .HasMany(r => r.Parts)
                        .WithMany(p => p.RemoteControls)
                        .Map(m => m.MapLeftKey("RemoteControls_Parts_Part_Id")
                                 .MapRightKey("Id")
                                 .ToTable("RemoteControls_Parts"));
            modelBuilder.Entity<RemoteControl>()
                        .HasKey(r => r.Id)
                        .HasMany(r => r.Properties)
                        .WithMany(p => p.RemoteControls)
                        .Map(m => m.MapLeftKey("RemoteControls_Properties_RemoteControl_Id")
                                 .MapRightKey("Id")
                                 .ToTable("RemoteControls_Properties"));
            modelBuilder.Entity<Part>()
                        .HasKey(p => p.Id)
                        .HasMany(r => r.Compoitions)
                        .WithMany(c => c.Parts)
                        .Map(m => m.MapLeftKey("Parts_Compositions_Composition_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Parts_Compositions"));
            modelBuilder.Entity<Part>()
                        .HasKey(p => p.Id)
                        .HasMany(r => r.Properties)
                        .WithMany(c => c.Parts)
                        .Map(m => m.MapLeftKey("Parts_Properties_Property_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Parts_Properties"));
            modelBuilder.Entity<Part>()
                        .HasKey(p => p.Id)
                        .HasMany(r => r.Upgrades)
                        .WithMany(c => c.Parts)
                        .Map(m => m.MapLeftKey("Parts_Upgrades_Upgrade_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Parts_Upgrades"));
            modelBuilder.Entity<Part>()
                        .HasKey(p => p.Id)
                        .HasMany(r => r.AssemblyStages)
                        .WithMany(c => c.Parts)
                        .Map(m => m.MapLeftKey("Parts_AssemblyStages_AssemblyStage_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Parts_AssemblyStages"));
            modelBuilder.Entity<Composition>().HasKey(c => c.Id);
            modelBuilder.Entity<Upgrade>()
                        .HasKey(u => u.Id)
                        .HasMany(up => up.Properties)
                        .WithMany(p => p.Upgrades)
                        .Map(m => m.MapLeftKey("Upgrades_Properties_Property_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Upgrades_Properties"));
            modelBuilder.Entity<Upgrade>()
                        .HasKey(u => u.Id)
                        .HasMany(up => up.UpgradeTypes)
                        .WithMany(p => p.Upgrades)
                        .Map(m => m.MapLeftKey("Upgrades_UpgradeTypes_UpgradeType_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Upgrades_UpgradeTypes"));
            modelBuilder.Entity<Property>().HasKey(p => p.Id);
            modelBuilder.Entity<Property>()
                        .HasKey(p => p.Id)
                        .HasMany(pv => pv.Values)
                        .WithMany(v => v.Properties)
                        .Map(m => m.MapLeftKey("Properties_Values_Parts_Value_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Properties_Values_Parts"));
            modelBuilder.Entity<Property>()
                        .HasKey(p => p.Id)
                        .HasMany(pu => pu.UpgradeTypes)
                        .WithMany(v => v.Properties)
                        .Map(m => m.MapLeftKey("Properties_UpgradeTypes_UpgradeType_Id")
                                 .MapRightKey("Id")
                                 .ToTable("Properties_UpgradeTypes"));
            modelBuilder.Entity<Value>().HasKey(v => v.Id);
            modelBuilder.Entity<UpgradeType>().HasKey(ut => ut.Id);
            modelBuilder.Entity<AssemblyStage>().HasKey(a => a.Id);
            modelBuilder.Entity<Property_Value_Part>().HasKey(pvp => pvp.Properties_Values_Parts_Id);
        }
        public virtual DbSet<RemoteControl> RemoteControls { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Composition> Compositions { get; set; }
        public virtual DbSet<Upgrade> Upgrades { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Value> Values { get; set; }
        public virtual DbSet<UpgradeType> UpgradeTypes { get; set; }
        public virtual DbSet<Property_Value_Part> Properties_Values_Parts { get; set; }
    }
}