using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Parts")]
    public class Part
    {
        [Key]
        public int Id { get;set;}
        [Display(Name = "Наименование детали")]
        public string Name { get; set; }
        [Display(Name = "Обозначение детали")]
        public string Designation { get; set; }
        public Composition Composition { get; set; }
        public virtual List<Property> Properties { get; set; }
        public virtual List<RemoteControl> RemoteControls { get; set; }
        public virtual List<Composition> Compoitions { get; set; }
        public virtual List<AssemblyStage> AssemblyStages { get; set; }
        public virtual List<Upgrade> Upgrades { get; set; }
        public virtual List<Property_Value_Part> Properties_Values_Parts { get; set; }
        public Part()
        {
            Properties = new List<Property>();
            RemoteControls = new List<RemoteControl>();
            Compoitions = new List<Composition>();
            AssemblyStages = new List<AssemblyStage>();
            Upgrades = new List<Upgrade>();
            Properties_Values_Parts = new List<Property_Value_Part>();
        }
    }
}