using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("ComponentParts")]
    public class ComponentPart
    {
        [Key]
        public int ComponentPartsId {get;set;}
        public string ComponentPartName { get; set; }
        public string ComponentPartDesignation { get; set; }
        public PlacementType ComponentPartSlotType { get; set; }
        public List<PlacementSlot> ComponentPartSlots { get; set; }
        public List<ComponentPart> ComponentPartParts { get; set; }
        public List<Property> ComponentPartProperties { get; set; }
        public Profield ComponentPartProfield { get; set; }
        public List<Impact> ComponentPartImpacts { get; set; }
        public ComponentPart()
        {
            ComponentPartSlots = new List<PlacementSlot>();
            ComponentPartParts = new List<ComponentPart>();
            ComponentPartProperties = new List<Property>();
            ComponentPartImpacts = new List<Impact>();
        }
    }
}