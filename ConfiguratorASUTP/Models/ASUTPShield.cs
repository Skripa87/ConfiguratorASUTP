using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("ASUTPShields")]
    public class ASUTPShield
    {
        [Key]
        public int ASUTPshieldId { get; set; }
        public string ASUTPShieldName { get; set; }
        public string ASUTPShieldDesignation { get; set; }
        public List<PlacementSlot> ASUTPShieldSlots { get; set; }
        public List<ComponentPart> ASUTPShieldParts { get; set; }
        public List<Property> ASUTPShieldProperties { get; set; }
        public Profield Profield { get; set; }
        public ASUTPShield()
        {
            ASUTPShieldSlots = new List<PlacementSlot>();
            ASUTPShieldParts = new List<ComponentPart>();
            ASUTPShieldProperties = new List<Property>();
        }
    }
}