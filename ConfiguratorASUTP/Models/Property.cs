using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Properties")]
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequared { get; set; }
        public virtual List<Value> Values { get; set; }
        public virtual List<Part> Parts { get; set; }
        public virtual List<Upgrade> Upgrades { get; set; }
        public virtual List<RemoteControl> RemoteControls { get; set; }
        public virtual List<UpgradeType> UpgradeTypes { get; set; }
        public virtual List<Property_Value_Part> Properties_Values_Parts { get; set; }
        public Property()
        {
            Values = new List<Value>();
            Parts = new List<Part>();
            RemoteControls = new List<RemoteControl>();
            Upgrades = new List<Upgrade>();
            UpgradeTypes = new List<UpgradeType>();
            Properties_Values_Parts = new List<Property_Value_Part>();
        }

    }
}