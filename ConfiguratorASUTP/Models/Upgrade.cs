using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Upgrades")]
    public class Upgrade
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual List<UpgradeType> UpgradeTypes { get; set; }
        public virtual List<Property> Properties { get; set; }
        public virtual List<Part> Parts { get; set; }
        public Upgrade()
        {
            Properties = new List<Property>();
            Parts = new List<Part>();
            UpgradeTypes = new List<UpgradeType>();
        }
    }
}