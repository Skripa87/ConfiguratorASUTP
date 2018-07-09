using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    public class UpgradeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Upgrade> Upgrades { get; set; }
        public virtual List<Property> Properties { get; set; }
        public UpgradeType()
        {
            Upgrades = new List<Upgrade>();
            Properties = new List<Property>();
        }
    }
}